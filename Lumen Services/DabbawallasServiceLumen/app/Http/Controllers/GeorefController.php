<?php

namespace App\Http\Controllers;

use DateTime;
use Illuminate\Http\Request;

class GeorefController extends Controller
{
    function geocodeResponse (Request $request){

        function geocode($address)
        {
            $address = urlencode($address);            
            $url = "https://maps.googleapis.com/maps/api/geocode/json?address={$address}&key=AIzaSyC3IIXSR89fmcEcNnODeKzBvwhfQb_LFCg";
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
                $calle= $obJson->calle;
                $comuna= $obJson->comuna;
                $ciudad= $obJson->ciudad;
                $direccion= $calle . ' ' . ' ' . $comuna . ' ' . $ciudad . ' Chile';
                $resp_geo = geocode($direccion);
                $latitud = $resp_geo['lat'];
                $longitud = $resp_geo['lng'];

                $array = [
                    'success'=> true,
                    'latitud' => $latitud,
                    'longitud' => $longitud,
                ];

                if(!$resp_geo){
                    return response()->json(['success' => false, 'error' => 'Dirección no encontrada'], 500);
                }else{
                    return  response()->json($array,200);
                }
            } else {
                return response()->json(['success' => false, 'error' => 'Debe ingresar un Json'], 400, []);
            }

        }
}
