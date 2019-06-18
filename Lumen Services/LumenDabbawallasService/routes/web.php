<?php

/*
|--------------------------------------------------------------------------
| Application Routes
|--------------------------------------------------------------------------
|
| Here is where you can register all of the routes for an application.
| It is a breeze. Simply tell Lumen the URIs it should respond to
| and give it the Closure to call when that URI is requested.
|
*/


$router->get('/', function () use ($router) {
    return $router->app->version();
});

$router->get('/key', function () {
    return str_random(32);
});

$router->post('/geocode',['uses'=>'GeorefController@geocodeResponse']);
$router->post('/pruebabd',['uses'=>'PruebaDBController@dbResponse']);
$router->put('/suscripcion/{id}',['uses'=>'SuscripcionController@update']);
$router->get('/alertasActivas',['uses'=>'AlertasController@verAlertasActivas']);
$router->put('/clausuraTicket/{id}',['uses'=>'TicketController@cerrarTicket']);
