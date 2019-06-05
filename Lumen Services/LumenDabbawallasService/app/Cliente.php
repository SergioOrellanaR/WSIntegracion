<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
//use App\PedidoEstado;
class Cliente extends Model
{
    protected $table = 'CLIENTE';
    protected $primaryKey = 'ID_CLIENTE';
    protected $dateFormat = 'U';
    public $timestamps = false;
    
    protected $fillable = [
        'ID_USUARIO', 'DIRECCION_HOGAR', 'DIRECCION_TRABAJO', 'ID_COMUNA_HOGAR', 'ID_COMUNA_TRABAJO', 'ID_ESTADO_SUSCRIPCION', 'ID_DABBAWALLA_ASOCIADO'
    ];
}