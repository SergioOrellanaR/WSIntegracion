<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="ConsultarDireccionSupervisor.aspx.cs" Inherits="DabbawallaView.ConsultarDireccionSupervisor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
        /* Always set the map height explicitly to define the size of the div
       * element that contains the map. */
        #map {
            height: 450px;
        }

        #map2 {
            height: 450px;
        }
    </style>

    <div class="container col s12 m4 l8">
        <div class="row">
            <div class="input-field col s6">
                <h5>Ingrese Usuario</h5>
                <asp:TextBox ID="txUsuario" type="text" placeholder="Usuario" runat="server"></asp:TextBox>
                <asp:Button type="submit" runat="server" Text="Buscar" class="btn" />
            </div>
            <div class="input-field col s6">
                <div class="icon-block">
                    <h5>Dirección Hogar</h5>
                    <div class="col s12 m12">
                        <div class="card-large card-panel hoverable">
                            <div id="map"></div>
                        </div>
                    </div>
                    <div class="col s12 m12">
                        <h5>Dirección Hogar</h5>
                        <div class="card-large card-panel hoverable">
                            <div id="map2"></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
     <script>
        var map;
        var map2;
        //function initMap() {
        //    map = new google.maps.Map(document.getElementById('map'), {
        //        center: { lat: -34.397, lng: 150.644 },
        //        zoom: 8
        //    });
        //}
        //function initMap2() {
        //    map2 = new google.maps.Map(document.getElementById('map2'), {
        //        center: { lat: -34.397, lng: 150.644 },
        //        zoom: 8
        //    });
        //}

        function initialize() {
            var myOptions = {
                center: { lat: -34.397, lng: 150.644 },
                zoom: 8
            }
            map = new google.maps.Map(document.getElementById("map"), myOptions);

            map2 = new google.maps.Map(document.getElementById("map2"), myOptions);
        }
    </script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyB_itV0_ef1EKFjbrUro5AddEcUvfL-9nE&callback=initialize"
        async defer></script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyB_itV0_ef1EKFjbrUro5AddEcUvfL-9nE&callback=initialize"
        async defer></script>
</asp:Content>
