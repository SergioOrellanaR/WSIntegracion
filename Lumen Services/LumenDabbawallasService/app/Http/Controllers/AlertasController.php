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
     $alertas = Alertas::all();
     //$estadoAlerta= $alertas->ID_TIPO_ALERTA;
    // $alertasActivas = Pedido::where('ID_TIPO_ALERTA',1)->select();
     $alertasActivas =DB::table('ALERTA')->where('ID_TIPO_ALERTA', '=', 1)->select();
     foreach ($alertasActivas as $alertasAc) {
        $ID_ALERTA= $alertasAc->ID_ALERTA;
        $ID_CLIENTE_ALERTA=$alertasAc->ID_CLIENTE_ALERTA;
        $ID_TIPO_ALERTA=$alertasAc->ID_TIPO_ALERTA;
        $FECHA_ALERTA=$alertasAc->FECHA_ALERT;


        $showAlertas[$contadorAlertas] = [
            'ID_ALERTA' => $ID_ALERTA,
            'ID_CLIENTE_ALERTA' => $ID_CLIENTE_ALERTA,
            'ID_TIPO_ALERTA' => $ID_TIPO_ALERTA,
            'FECHA_ALERTA' => $FECHA_ALERTA,
        ];
        $contadorAlertas++;
     }
     return response()->json([$alertasAc],200);
    }

}
