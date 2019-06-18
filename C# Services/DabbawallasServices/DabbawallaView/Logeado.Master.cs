using DabbawallasREST.Models.Responses;
using System;

namespace DabbawallaView
{
    public partial class Logeado : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                LoginResponse user = DeserealizeSesion();
                switch (user.IdTipoUsuario)
                {
                    case 1:
                        MenuCliente.Visible = true;
                        MenuDabbawalla.Visible = false;
                        MenuSupervisor.Visible = false;
                        break;
                    case 2:
                        MenuCliente.Visible = false;
                        MenuDabbawalla.Visible = true;
                        MenuSupervisor.Visible = false;
                        break;
                    case 3:
                        MenuCliente.Visible = false;
                        MenuDabbawalla.Visible = false;
                        MenuSupervisor.Visible = true;
                        break;
                    default:
                        MenuCliente.Visible = false;
                        MenuDabbawalla.Visible = false;
                        MenuSupervisor.Visible = false;
                        break;
                }
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }

        public LoginResponse DeserealizeSesion ()
        {
            return (LoginResponse)Session["ses"];
        }
    }
}