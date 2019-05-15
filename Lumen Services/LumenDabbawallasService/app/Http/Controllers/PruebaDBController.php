<?php

namespace App\Http\Controllers;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

use Laravel\Lumen\Routing\Controller as Controller;

class PruebaDBController extends Controller
{
    function dbResponse (Request $request){
        if ($request->isJson())
        {
            $obJson = json_decode($request->getContent());
            $id = $obJson->id;
            $idValido = DB::table('dbo.TIPO_ALERTA')->where('ID_TIPO_ALERTA', '=', $id)->select()->first();
            $tipoAlerta= $idValido->TIPO_ALERTA;
                return response()->json(['success' => true, 'Tipo Alerta' => $tipoAlerta], 200);
        }
    }

}
