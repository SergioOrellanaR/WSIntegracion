<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuscripcionValida.aspx.cs" Inherits="DabbawallaView.SuscripcionValida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Dabbawallas Chile</title>
    <!-- CSS  -->
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link href="css/materialize.css" type="text/css" rel="stylesheet" media="screen,projection" />
    <link href="css/style.css" type="text/css" rel="stylesheet" media="screen,projection" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
</head>
<body background="santiago_fondo.jpg">
    <form id="form1" runat="server">

        <div id="index-banner" class="parallax-container">
            <div class="section no-pad-bot">
                <div class="container">
                    <br>
                    <br>
                    <h1 class="header center teal-text text-lighten-2">Gracias por la Suscripción</h1>
                    <div class="row center">
                        <h4 class="header col s12 text-lighten-2 black-text">Ahora podrar disfrutar de todos los servicios ofrecidos por Dabbawallas Chile</h4>
                    </div>
                    <div class="row center">
                        <a href="IndexLog.aspx" id="download-button" class="btn-large waves-effect waves-light teal lighten-1">Volver</a>
                    </div>
                    <br>
                    <br>
                </div>
            </div>
        </div>



        <style>
            .background {
                width:100%;
                background-size:cover;
            }
            .indicator-item {
                padding: 10px;
            }
        </style>
    </form>
    <script src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="js/materialize.js"></script>
    <script src="js/init.js"></script>
</body>
</html>
