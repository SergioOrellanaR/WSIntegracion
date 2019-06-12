using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using DabbawallaView.Classes;
using DabbawallasREST.Models;
using DabbawallasREST.Models.Responses;
using Newtonsoft.Json;

namespace DabbawallaView
{
    public partial class Logeado : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ses"] != null)
                {
                    LoginResponse user = (LoginResponse)Session["ses"];
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
        }
    }
}