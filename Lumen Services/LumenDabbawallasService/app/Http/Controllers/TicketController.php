<?php

namespace App\Http\Controllers;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Laravel\Lumen\Routing\Controller as Controller;
use App\Ticket;

class TicketController extends Controller
{
    public function cerrarTicket(Request $request, $id)
    {
        if ($request->isJson())
        {
            $obJson = json_decode($request->getContent());
            $calificacion= $obJson->calificacion;
            // $fechaClausura=date('Y-m-d H:i:s');
            if($calificacion>=0 && $calificacion<=5){
                $ticket= Ticket::find($id);
                $estado= $ticket->ID_ESTADO;
                if($estado>0 && $estado<=4){
                    $ticket->CALIFICACION_SERVICIO = $request->input('calificacion');
                    // $ticket->FECHA_CLAUSURA=$fechaClausura;
                    $ticket->ID_ESTADO = 5;
                    $ticket->save();
                    return  response()->json($ticket,200);
                }else{
                    return response()->json(['success' => false, 'error' => "No existe ningun ticket abierto con este ID: $id" ], 401);
                }                
            }else{
                return response()->json(['success' => false, 'error' => 'La calificacion debe ser entre 0 y 5'], 500);
            }            
        }else{
            return response()->json(['success' => false, 'error' => 'Debe ingresar un Json'], 400);
        }
     }
}