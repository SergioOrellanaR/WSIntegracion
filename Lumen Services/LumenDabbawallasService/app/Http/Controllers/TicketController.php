<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Laravel\Lumen\Routing\Controller as Controller;
use App\Ticket;

class TicketController extends Controller
{
    public function cerrarTicket(Request $request)
    {
        if ($request->isJson()) {
            $obJson = json_decode($request->getContent());
            $username = $obJson->Username;
            $calificacion = $obJson->Calificacion;            
            $usuarioValido = DB::table('dbo.USUARIO')->where('USERNAME', '=', $username)->select('ID_USUARIO')->first();
            if($usuarioValido!=null){
                $id_usuario_recibe = $usuarioValido->ID_USUARIO;
                $clienteValido = DB::table('dbo.CLIENTE')->where('ID_USUARIO', '=', $id_usuario_recibe)->select('ID_CLIENTE')->first();
                $id_cliente_recibe = $clienteValido->ID_CLIENTE;
                $whereUsuario = [
                    ['ID_CLIENTE_RECIBE', '=', $id_cliente_recibe],
                    ['ID_ESTADO', '>', 0],
                    ['ID_ESTADO', '<=', 4],
                ];
                $id_valido = DB::table('dbo.TICKET')->where($whereUsuario)->select()->first();            
                if ($id_valido != null) {
                    $id_ticket = $id_valido->ID_TICKET;
                    if ($calificacion >= 0 && $calificacion <= 5) {
                        $ticket = Ticket::find($id_ticket);
                        $estado = $ticket->ID_ESTADO;
                        if ($estado > 0 && $estado <= 4) {
                            $ticket->CALIFICACION_SERVICIO = $request->input('Calificacion');
                            $ticket->ID_ESTADO = 5;
                            $ticket->save();
                            return  response()->json(['succes'=>true, 'Ticket' =>$ticket], 200);
                        } else {
                            return response()->json(['success' => false, 'error' => "No existe ningun ticket abierto con este ID:"], 401);
                        }
                    } else {
                        return response()->json(['success' => false, 'error' => 'La calificacion debe ser entre 0 y 5'], 500);
                    }
                }else{
                    return response()->json(['success' => false, 'error' => "No tiene ningun ticket abierto"], 401);
                } 
            }else{
                return response()->json(['success' => false, 'error' => "Username Invalido"], 401);
            }
                       
        } else {
            return response()->json(['success' => false, 'error' => 'Debe ingresar un Json'], 400);
        }
    }
}
