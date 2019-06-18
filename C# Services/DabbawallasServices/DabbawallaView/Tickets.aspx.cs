using DabbawallasBusiness.Classes;
using DabbawallasREST.Models;
using DabbawallasREST.Models.Responses;
using DabbawallaView.Classes;
using Newtonsoft.Json;
using System;

namespace DabbawallaView
{
    public partial class Tickets : System.Web.UI.Page
    {
        RESTWebCaller caller = new RESTWebCaller();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                int idCliente = 1;
                LoginResponse user = DeserealizeSesion();
                if (user.IdTipoUsuario == idCliente)
                {
                    Cliente client = new Cliente(user.IdUsuario);
                }
                else
                {
                    Response.Redirect("IndexLog.aspx");
                }
            }
        }

        public LoginResponse DeserealizeSesion()
        {
            return (LoginResponse)Session["ses"];
        }

        protected void ValidateUserExists_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            LoginResponse response = DeserealizeSesion();
            Usuario user = new Usuario();
            if (user.ReadUserByUsername(txUsuario.Text) == true)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void EnviarTicket_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LoginResponse user = DeserealizeSesion();
                OpenTicketRequest ticketRequest = new OpenTicketRequest()
                {
                    UsernameClienteEnvia = user.Username,
                    UsernameClienteRecibe = txUsuario.Text
                };

                string openTicketURL = "http://localhost:6970/dabbawallas/clientes/abrir_ticket";

                string jsonRequest = JsonConvert.SerializeObject(ticketRequest);
                string jsonResponse = caller.MethodCallerPOST(openTicketURL, jsonRequest);

                if (jsonResponse != null)
                {
                    TicketResponse openTicketResponse = JsonConvert.DeserializeObject<TicketResponse>(jsonResponse);
                    lblTicketStatus.Text = "se ha abierto con éxito un ticket al usuario "+ticketRequest.UsernameClienteRecibe;
                }
                else
                {
                    lblTicketStatus.Text = "Ha habido un error al procesar su ticket";
                }
            }
        }
    }
}