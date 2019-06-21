using DabbawallasBusiness.Classes;
using DabbawallasREST.Models;
using DabbawallasREST.Models.Responses;
using DabbawallaView.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DabbawallaView
{
    public partial class Suscripcion : System.Web.UI.Page
    {
        RESTWebCaller caller = new RESTWebCaller();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                LoginResponse user = DeserealizeSesion();
                switch (user.IdTipoUsuario)
                {
                    case 1:
                        int inactiveSuscription = 0;
                        Cliente client = new Cliente();
                        client = client.SearchClientByUsername(user.Username);
                        if (client.IdEstadoSuscripcion == inactiveSuscription)
                            lblMessage.Text = "Usted no posee una suscripción activa";
                        else
                        {
                            lblMessage.Text = "Ya tiene una suscripción activa";
                            lblSuscripcion.Visible = false;
                            btnSuscripcion.Visible = false;
                        }
                        break;
                    default:
                        Response.Redirect("IndexLog.aspx");
                        break;
                }
            }
        }

        public LoginResponse DeserealizeSesion()
        {
            return (LoginResponse)Session["ses"];
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            string registerUrl = "http://localhost:6970/activar_suscripcion";
            LoginResponse user = DeserealizeSesion();
            GenericClientRequest activateRequest = new GenericClientRequest()
            {
                Username = user.Username
            };

            string jsonRequest = JsonConvert.SerializeObject(activateRequest);
            string jsonResponse = caller.MethodCallerPOST(registerUrl, jsonRequest);

            if (jsonResponse != null)
            {
                Response.Redirect("SuscripcionValida.aspx");
            }
            else
            {
                Response.Redirect("Suscripcion.aspx");
            }
        }
    }
}