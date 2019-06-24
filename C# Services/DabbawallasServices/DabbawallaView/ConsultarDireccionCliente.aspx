<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="ConsultarDireccionCliente.aspx.cs" Inherits="DabbawallaView.ConsultarDireccionCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
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
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container col s12 m4 l8">
        <div class="row">
            <div class="input-field col s6">
                <asp:TextBox ID="txtBuscadorClientes" runat="server" Visible="false" Text="Ingrese Username"></asp:TextBox>
                <asp:CustomValidator ID="ValidateUserExists" runat="server" ErrorMessage="El cliente ingresado no existe" ControlToValidate="txtBuscadorClientes" ForeColor="Red" OnServerValidate="ValidateUserExists_ServerValidate"></asp:CustomValidator>
                <asp:DropDownList class="form-control dropdown-trigger btn" ID="ddlClientesAsociados" runat="server">
                </asp:DropDownList>
                <asp:Button ID="btnBuscarDireccion" runat="server" Text="Buscar dirección de cliente" OnClick="btnBuscarDireccion_Click" Visible="false" class="btn" />
                <br />
                <h4>
                    <asp:Label ID="lblClienteBuscado" runat="server" Text=""></asp:Label>
                </h4>
            </div>

            <div class="input-field col s6">
                <div class="icon-block">
                    <h4>
                        <asp:Label ID="lblHogarHeader" runat="server" Text="Direccion de hogar" Visible="false"></asp:Label></h4>
                    <br />
                    <asp:Label ID="lblDireccionHogar" runat="server" Text=""></asp:Label>
                    <div class="col s12 m12">
                        <div class="card-large card-panel hoverable" id="mapBox">
                            <div id="map"></div>
                        </div>
                    </div>
                    <div class="col s12 m12">
                        <h4>
                            <asp:Label ID="lblTrabajoHeader" runat="server" Text="Dirección de trabajo" Visible="false"></asp:Label></h4>

                        <br />
                        <asp:Label ID="lblDireccionTrabajo" runat="server" Text=""></asp:Label>
                        <div class="card-large card-panel hoverable" id="map2Box">
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

            var getUrlParameter = function getUrlParameter(sParam) {
                var sPageURL = window.location.search.substring(1),
                    sURLVariables = sPageURL.split('&'),
                    sParameterName,
                    i;

                for (i = 0; i < sURLVariables.length; i++) {
                    sParameterName = sURLVariables[i].split('=');

                    if (sParameterName[0] === sParam) {
                        return sParameterName[1] === undefined ? true : decodeURIComponent(sParameterName[1]);
                    }
                }
            };

            //var myOptions = {
            //    center: { lat: -33.474, lng: -70.749 },
            //    zoom: 8
            //}
            var validateHogar = parseFloat(getUrlParameter('latHogar'));

            if (!isNaN(validateHogar)) {
                var latHogar = parseFloat(getUrlParameter('latHogar').replace(",", "."));
                var lonHogar = parseFloat(getUrlParameter('lonHogar').replace(",", "."));
                var HorLatLng = { lat: latHogar, lng: lonHogar };
                var dirHogar = {
                    center: HorLatLng,
                    zoom: 16
                }
                var markerHogar = new google.maps.Marker({
                    position: HorLatLng,
                    map: map,
                    title: 'Dirección de hogar de cliente'
                });
                map = new google.maps.Map(document.getElementById("map"), dirHogar);
                markerHogar.setMap(map);
            }
            else {
                $("#map").hide();
                $("#mapBox").hide();
            }

            var validateTrabajo = parseFloat(getUrlParameter('latTrab'));

            if (!isNaN(validateTrabajo)) {
                var latTrab = parseFloat(getUrlParameter('latTrab').replace(",", "."));
                var lonTrab = parseFloat(getUrlParameter('lonTrab').replace(",", "."));
                var TraLatLng = { lat: latTrab, lng: lonTrab };
                //var TraLatLng = { lat: null, lng: null };
                var dirTrab = {
                    center: TraLatLng,
                    zoom: 16
                }
                var markerTrab = new google.maps.Marker({
                    position: TraLatLng,
                    map: map2,
                    title: 'Dirección de trabajo de cliente'
                });
                map2 = new google.maps.Map(document.getElementById("map2"), dirTrab);
                markerTrab.setMap(map2);
            }
            else {
                $("#map2").hide();
                $("#map2Box").hide();
            }

        }
    </script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyB_itV0_ef1EKFjbrUro5AddEcUvfL-9nE&callback=initialize"
        async defer></script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyB_itV0_ef1EKFjbrUro5AddEcUvfL-9nE&callback=initialize"
        async defer></script>
</asp:Content>
