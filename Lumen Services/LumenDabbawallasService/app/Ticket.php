<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
//use App\PedidoEstado;
class Ticket extends Model
{
    protected $table = 'TICKET';
    protected $primaryKey = 'ID_TICKET';
    //protected $dateFormat = 'Y-d-m H:i:s.v';
    protected $dateFormat = 'Y-m-d\TH:i:s';
    const UPDATED_AT='FECHA_CLAUSURA';
    // public $timestamps = false;
    
    protected $fillable = [
        'ID_TICKET', 'ID_CLIENTE_ENVIA', 'ID_CLIENTE_RECIBE', 'ID_ESTADO', 'FECHA_APERTURA', 'FECHA_CLAUSURA', 'CALIFICACION_SERVICIO'
    ];
}
