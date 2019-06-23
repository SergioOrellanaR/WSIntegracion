using DabbawallasBusiness.Classes;
using DabbawallasREST.Models;
using DabbawallasREST.Models.Responses;
using DabbawallaView.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web;

namespace DabbawallaView
{
    public partial class ConsultarDireccionCliente : System.Web.UI.Page
    {
        RESTWebCaller caller = new RESTWebCaller();
        //static bool wasParametersAdded = false;

        static string direccionTrabajo;
        static string direccionHogar;
        static string usernameCliente;
        //static string loadedUserUrl;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                //wasParametersAdded = urlHasParameters();
                LoginResponse user = DeserealizeSesion();
                Cliente client = new Cliente();
                switch (user.IdTipoUsuario)
                {
                    case 1:
                        btnBuscarDireccion.Visible = false;
                        txtBuscadorClientes.Visible = false;
                        ddlClientesAsociados.Visible = false;
                        client = client.SearchClientByUsername(user.Username);

                        if (!urlHasParameters())
                        {
                            LoadClientMap(client);
                        }
                        else
                        {
                            //Url tiene parametros: Si
                            //Url actualizada, es igual a la url actual?
                            //Si: No hagas nada
                            //No: Carga la información de la nueva URL
                            LoadAddressInformation();
                        }
                        
                        break;
                    case 2:
                        Dabbawalla dab = new Dabbawalla();
                        dab = dab.SearchDabbawallaByUsername(user.Username);
                        btnBuscarDireccion.Visible = true;
                        ddlClientesAsociados.Visible = true;
                        txtBuscadorClientes.Visible = false;
                        if (!Page.IsPostBack)
                        {
                            ddlClientesAsociados.DataSource = ClientUsernameList(dab);
                            ddlClientesAsociados.DataBind();
                        }


                        if (!urlHasParameters())
                        {
                            usernameCliente = null;
                            direccionHogar = null;
                            direccionTrabajo = null;
                        }
                        LoadAddressInformation();
                        break;
                    case 3:
                        btnBuscarDireccion.Visible = true;
                        txtBuscadorClientes.Visible = true;
                        ddlClientesAsociados.Visible = false;
                        if (!urlHasParameters())
                        {
                            usernameCliente = null;
                            direccionHogar = null;
                            direccionTrabajo = null;
                        }
                        LoadAddressInformation();
                        break;
                    default:
                        break;
                }

            }
        }

        public LoginResponse DeserealizeSesion()
        {
            return (LoginResponse)Session["ses"];
        }

        public GeoElementResponse ResponseGeocode(string username)
        {
            string geoCodeUrl = "http://localhost:6969/geocode";
            GenericClientRequest request = new GenericClientRequest()
            {
                Username = username
            };

            string jsonRequest = JsonConvert.SerializeObject(request);
            string jsonResponse = caller.MethodCallerPOST(geoCodeUrl, jsonRequest);

            GeoElementResponse response = new GeoElementResponse();

            if (jsonResponse != null)
            {
                response = JsonConvert.DeserializeObject<GeoElementResponse>(jsonResponse);
            }
            else
            {
                response = null;
            }

            return response;
        }

        //public string BuildUrl(Cliente cliente)
        //{
        //    string username = cliente.Username;
        //    GeoElementResponse response = ResponseGeocode(username);

        //    var uriBuilder = new UriBuilder(Request.Url.AbsoluteUri);
        //    var paramValues = HttpUtility.ParseQueryString(uriBuilder.Query);

        //    if (response != null)
        //    {
        //        //lblClienteBuscado.Text = "Dirección de: " + cliente.Username;
        //        usernameCliente = cliente.Username;
        //        paramValues.Add("latHogar", response.Hogar.Latitud.ToString());
        //        paramValues.Add("lonHogar", response.Hogar.Longitud.ToString());

        //        direccionHogar = cliente.AddressAndComune(cliente.DireccionHogar, cliente.IdComunaHogar);
        //        //lblHogarHeader.Visible = true;
        //        //lblDireccionHogar.Visible = true;
        //        //lblDireccionHogar.Text = cliente.AddressAndComune(cliente.DireccionHogar, cliente.IdComunaHogar);


        //        if (response.Trabajo.Latitud != null)
        //        {
        //            paramValues.Add("latTrab", response.Trabajo.Latitud.ToString());
        //            paramValues.Add("lonTrab", response.Trabajo.Longitud.ToString());

        //            direccionTrabajo = cliente.AddressAndComune(cliente.DireccionTrabajo, cliente.IdComunaTrabajo);
        //            //lblTrabajoHeader.Visible = true;
        //            //lblDireccionTrabajo.Visible = true;
        //            //lblDireccionTrabajo.Text = cliente.AddressAndComune(cliente.DireccionTrabajo, cliente.IdComunaTrabajo);
        //        }
        //        else
        //        {
        //            paramValues.Add("latTrab", "null");
        //            paramValues.Add("lonTrab", "null");
        //            //lblTrabajoHeader.Visible = false;
        //            //lblDireccionTrabajo.Visible = false;
        //        }
        //    }
        //    else
        //    {
        //        paramValues.Add("latHogar", "null");
        //        paramValues.Add("lonHogar", "null");
        //        //lblHogarHeader.Visible = false;
        //        //lblDireccionHogar.Visible = false;
        //        //lblTrabajoHeader.Visible = false;
        //        //lblDireccionTrabajo.Visible = false;
        //    }

        //    uriBuilder.Query = paramValues.ToString();

        //    string val = uriBuilder.Uri.ToString();
        //    wasParametersAdded = true;
        //    return val;
        //}

        public string BuildUrl(Cliente cliente)
        {
            string username = cliente.Username;
            GeoElementResponse response = ResponseGeocode(username);

            var uriBuilder = new UriBuilder(Request.Url.AbsoluteUri);
            var paramValues = HttpUtility.ParseQueryString(uriBuilder.Query);
            string latHogar;
            string lonHogar;
            string latTrab = "null";
            string lonTrab = "null";

            if (response != null)
            {
                //lblClienteBuscado.Text = "Dirección de: " + cliente.Username;
                usernameCliente = cliente.Username;
                latHogar = response.Hogar.Latitud.ToString();
                lonHogar = response.Hogar.Longitud.ToString();
                //paramValues.Add("latHogar", response.Hogar.Latitud.ToString());
                //paramValues.Add("lonHogar", response.Hogar.Longitud.ToString());

                direccionHogar = cliente.AddressAndComune(cliente.DireccionHogar, cliente.IdComunaHogar);
                //lblHogarHeader.Visible = true;
                //lblDireccionHogar.Visible = true;
                //lblDireccionHogar.Text = cliente.AddressAndComune(cliente.DireccionHogar, cliente.IdComunaHogar);


                if (response.Trabajo.Latitud != null)
                {
                    latTrab = response.Trabajo.Latitud.ToString();
                    lonTrab = response.Trabajo.Longitud.ToString();

                    direccionTrabajo = cliente.AddressAndComune(cliente.DireccionTrabajo, cliente.IdComunaTrabajo);
                    //lblTrabajoHeader.Visible = true;
                    //lblDireccionTrabajo.Visible = true;
                    //lblDireccionTrabajo.Text = cliente.AddressAndComune(cliente.DireccionTrabajo, cliente.IdComunaTrabajo);
                }
                else
                {
                    latTrab = "null";
                    lonTrab = "null";
                    //lblTrabajoHeader.Visible = false;
                    //lblDireccionTrabajo.Visible = false;
                }
            }
            else
            {
                latHogar = "null";
                lonHogar = "null";
                //lblHogarHeader.Visible = false;
                //lblDireccionHogar.Visible = false;
                //lblTrabajoHeader.Visible = false;
                //lblDireccionTrabajo.Visible = false;
            }

            uriBuilder.Query = paramValues.ToString();

            string val = "ConsultarDireccionCliente.aspx?latHogar=" + latHogar + "&lonHogar=" + lonHogar +
                "&latTrab=" + latTrab + "&lonTrab=" + lonTrab;
            val = val.Replace(",", "%2c");
            //wasParametersAdded = true;
            return val;
        }

        protected void btnBuscarDireccion_Click(object sender, EventArgs e)
        {
            Cliente client = new Cliente();
            if (ddlClientesAsociados.Visible == true)
            {
                client = client.SearchClientByUsername(ddlClientesAsociados.SelectedValue);
                usernameCliente = client.Username;
                LoadClientMap(client);
            }
            else
            {
                if (txtBuscadorClientes.Visible == true && Page.IsValid)
                {
                    client = client.SearchClientByUsername(txtBuscadorClientes.Text);
                    LoadClientMap(client);
                    //wasParametersAdded = false;
                }
            }
        }

        private void LoadClientMap(Cliente client)
        {
            //loadedUserUrl = BuildUrl(client);
            Response.Redirect(BuildUrl(client));
        }

        //Carga la información y luego la borra del caché
        private void LoadAddressInformation()
        {
            if (usernameCliente != null)
            {
                lblClienteBuscado.Text = "Dirección de: " + usernameCliente;
            }

            if (direccionHogar != null)
            {
                lblHogarHeader.Visible = true;
                lblDireccionHogar.Visible = true;
                lblDireccionHogar.Text = direccionHogar;
            }

            if (direccionTrabajo != null)
            {
                lblTrabajoHeader.Visible = true;
                lblDireccionTrabajo.Visible = true;
                lblDireccionTrabajo.Text = direccionTrabajo;
            }

            //usernameCliente = null;
            //direccionHogar = null;
            //direccionTrabajo = null;
        }

        private bool QueriedDirectionIsTheSame (string actualUrl, string queriedUrl)
        {
            return actualUrl == queriedUrl;
        }

        private List<string> ClientUsernameList(Dabbawalla dab)
        {
            List<string> namesList = new List<string>();
            List<Cliente> clientesList = dab.AssociatedClients();

            foreach (Cliente cli in clientesList)
            {
                namesList.Add(cli.Username);
            }

            return namesList;
        }

        protected void ValidateUserExists_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            LoginResponse response = DeserealizeSesion();
            Usuario user = new Usuario();
            if (user.ReadUserByUsername(txtBuscadorClientes.Text) == true)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        private bool urlHasParameters()
        {
            string actualUrl = Request.Url.ToString();
            int noParametersPathLength = 53;
            if (actualUrl.Length > noParametersPathLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class AddressesInformation
    {
        public static string Username { get; set; }
        public static string DireccionHogar { get; set; }
        public static string DireccionTrabajo { get; set; }

    }
}