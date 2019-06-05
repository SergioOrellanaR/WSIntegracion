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
       $cliente= Cliente::find($id);
       $cliente->ID_ESTADO_SUSCRIPCION = $request->input('suscripcion');
       $cliente->save();
       return response()->json($cliente);
    }
}