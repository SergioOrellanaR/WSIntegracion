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
     return response()->json($alertasActivas,200);


    }
}