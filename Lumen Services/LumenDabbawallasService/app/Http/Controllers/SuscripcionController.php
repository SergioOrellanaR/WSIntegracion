<?php

namespace App\Http\Controllers;
use App\Cliente;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Laravel\Lumen\Routing\Controller as Controller;

class SuscripcionController extends Controller
{

    public function update(Request $request, $id)
    { 
        if ($request->isJson())
        {
            $obJson = json_decode($request->getContent());
            $suscripcion= $obJson->suscripcion;
            if($suscripcion==0 || $suscripcion==1){
                $cliente= Cliente::find($id);
                $cliente->ID_ESTADO_SUSCRIPCION = $request->input('suscripcion');
                $cliente->save();
                return  response()->json($cliente,200);
            }else{
                return response()->json(['success' => false, 'error' => 'El estado de la suscripcion debe ser 0 o 1'], 500);
            }            
        }else{
            return response()->json(['success' => false, 'error' => 'Debe ingresar un Json'], 400);
        }
       
    }
}