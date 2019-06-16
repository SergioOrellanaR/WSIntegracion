<?php

namespace App\Http\Controllers;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Laravel\Lumen\Routing\Controller as Controller;

class GeorefController extends Controller
{
    function geocodeResponse (Request $request){

        function geocode($address)
        {
            $address = urlencode($address);
            $url = "https://maps.googleapis.com/maps/api/geocode/json?address={$address}&key=AIzaSyCGxGr53qOA7mqwxDX6u2ShG3GuKgcEaNI";
            $resp_json = file_get_contents($url);
            $resp = json_decode($resp_json, true);
            if (empty($resp)) {
                return false;
            } else {
                if ($resp['status'] == 'OK') {
                    $tipo = $resp['results'][0]['types'][0];
                    if ($tipo == "street_address") {
                        $location = $resp['results'][0]['geometry']['location'];
                        return $location;
                    } else {
                        return false;
                    }
                } else {
                    return false;
                }
            }
        }

        if ($request->isJson())
        {
            $obJson = json_decode($request->getContent());
            $username = $obJson->username;
            $usuarioValido = DB::table('dbo.VISTA_INFORMACION_CLIENTES_SUSCRITOS')->where('USERNAME_CLIENTE', '=', $username)->select()->first();
            if ($usuarioValido==true){
                $direccionHogar= $usuarioValido->DIRECCION_HOGAR;
                $comunaHogar= $usuarioValido->COMUNA_HOGAR;
                $direccionTrabajo= $usuarioValido->DIRECCION_TRABAJO;
                $comunaTrabajo= $usuarioValido->COMUNA_TRABAJO;
                $hogarFinal=  $direccionHogar . ' ' . $comunaHogar . ' Chile';
                $trabajoFinal= $direccionTrabajo . ' '. $comunaTrabajo .' Chile';

                $resp_geoHogar = geocode($hogarFinal);
                $resp_geoTrabajo = geocode($trabajoFinal);
                $latitudHogar = $resp_geoHogar['lat'];
                $longitudHogar = $resp_geoHogar['lng'];
                $latitudTrabajo = $resp_geoTrabajo['lat'];
                $longitudTrabajo = $resp_geoTrabajo['lng'];


                $arrayHogar = [
                    'success'=> true,
                    'latitud' => $latitudHogar,
                    'longitud' => $longitudHogar,
                ];

                $arrayTrabajo = [
                    'latitud' => $latitudTrabajo,
                    'longitud' => $longitudTrabajo,
                ];
                return  response()->json(['Hogar' => $arrayHogar, 'Trabajo' =>$arrayTrabajo],200);
            }else{
                return  response()->json(['succes' => false, 'error' => 'Usuario no valido'],500);
            }
        } else {
            return response()->json(['success' => false, 'error' => 'Debe ingresar un Json'], 400);
        }
    }
}
