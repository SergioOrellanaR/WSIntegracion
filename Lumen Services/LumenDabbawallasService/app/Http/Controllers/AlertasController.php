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

     $alertasActivas =DB::table('ALERTA')->where('ID_TIPO_ALERTA', '=', 1)->get();
     if($alertasActivas==null){
         return response()->json($alertasActivas,200);
     }else{
         return response()->json(['error' => 'No se encuentran alertas activas'], 404);
     }

    }
}
