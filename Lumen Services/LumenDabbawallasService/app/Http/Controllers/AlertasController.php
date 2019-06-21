<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Laravel\Lumen\Routing\Controller as Controller;
use App\Alertas;

class AlertasController extends Controller
{
    public function verAlertasActivas(Request $request)
    {
        $listado = [];
        $obJson = json_decode($request->getContent());
        $username = $obJson->Username;
        $idusuario = DB::table('USUARIO')->where('USERNAME', '=', $username)->select('ID_USUARIO')->first();
        if ($idusuario != null) {
            $ID_USUARIO = $idusuario->ID_USUARIO;
            $idsupervisor = DB::table('SUPERVISOR')->where('ID_USUARIO', '=', $ID_USUARIO)->select('ID_SUPERVISOR')->first();
            if ($idsupervisor != null) {
                $ID_SUPERVISOR = $idsupervisor->ID_SUPERVISOR;
                $alertas = DB::table('VISTA_ALERTAS_ACTIVAS')->where('ID_SUPERVISOR_ALERTADO', '=', $ID_SUPERVISOR)->get();
                if($alertas->isNotEmpty()){
                    foreach ($alertas as $item) {
                        $ID_ALERTA = $item->ID_ALERTA;
                        $FECHA_ALERTA = $item->FECHA_ALERTA;
                        $USERNAME_CLIENTE_ALERTA = $item->USERNAME_CLIENTE_ALERTA;
                        $DIRECCION_HOGAR = $item->DIRECCION_HOGAR_CLIENTE_ALERTA;
                        $COMUNA_HOGAR = $item->COMUNA_HOGAR_CLIENTE_ALERTA;
                        $USER_DABB = $item->USERNAME_DABBAWALLA_ALERTADO;
                        $CELULAR = $item->CELULAR_DABBAWALLA_ALERTADO;
    
                        array_push($listado, [
                            'IdAlerta' => $ID_ALERTA, 'FechaAlerta' => $FECHA_ALERTA, 'UsernameClienteAlerta' => $USERNAME_CLIENTE_ALERTA,
                            'DireccionHogar' => $DIRECCION_HOGAR, 'ComunaHogar' => $COMUNA_HOGAR, 'UsernameDabbawallaAlertado' => $USER_DABB, 'CelularDabbawallaAlertado' => $CELULAR
                        ]);
                    }
                }else{
                    return response()->json(['success' => true, 'mensaje' => "No cuenta con alertas activas"], 404);
                }             
                return response()->json($listado, 200);
            }else{
                return response()->json(['success' => false, 'error' => "Username ingresado no corresponde a un supervisor"], 400);
            }
        } else {
            return response()->json(['success' => false, 'error' => "Username Invalido"], 400);
        }
    }
}
