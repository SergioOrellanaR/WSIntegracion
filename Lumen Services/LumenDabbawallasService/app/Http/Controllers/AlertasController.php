<?php

namespace App\Http\Controllers;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Laravel\Lumen\Routing\Controller as Controller;
use App\Alertas;

class AlertasController extends Controller
{
    public function verAlertasActivas()
    {
     $contadorAlertas = 0;
     //$alertasActivas=[];
     //$alertas = Alertas::all();
     //$estadoAlerta= $alertas->ID_TIPO_ALERTA;
    // $alertasActivas = Pedido::where('ID_TIPO_ALERTA',1)->select();
     $alertasActivas =DB::table('ALERTA')->where('ID_TIPO_ALERTA', '=', 1)->select()->first();
     if($alertasActivas){
     foreach ($alertasActivas as $alertasAc) {
        $ID_ALERTA= $alertasActivas->ID_ALERTA;
        $ID_CLIENTE_ALERTA=$alertasActivas->ID_CLIENTE_ALERTA;
        $ID_TIPO_ALERTA=$alertasActivas->ID_TIPO_ALERTA;
        $FECHA_ALERTA=$alertasActivas->FECHA_ALERTA;


        $showAlertas[$contadorAlertas] = [
            'ID_ALERTA' => $ID_ALERTA,
            'ID_CLIENTE_ALERTA' => $ID_CLIENTE_ALERTA,
            'ID_TIPO_ALERTA' => $ID_TIPO_ALERTA,
            'FECHA_ALERTA' => $FECHA_ALERTA,
        ];
        $contadorAlertas++;
     }
     return response()->json($showAlertas,200);
    }else{
        return response()->json(['success' => false, 'error' => 'No hay alertas activas'], 500);
    }
}
}
