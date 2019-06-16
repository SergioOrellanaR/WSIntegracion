<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
//use App\PedidoEstado;
class Alertas extends Model
{
    protected $table = 'ALERTA';
    protected $primaryKey = 'ID_ALERTA';
    protected $dateFormat = 'U';
    public $timestamps = false;

    protected $fillable = [
        'ID_ALERTA', 'ID_CLIENTE_ASOCIADO', 'ID_TIPO_ALERTA', 'FECHA_ALERTA'
    ];
}
