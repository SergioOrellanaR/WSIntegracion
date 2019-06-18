using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DabbawallasREST.Models.Responses;

namespace DabbawallaView
{
    public partial class IndexLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                LoginResponse loginResponse = (LoginResponse) Session["ses"];
                lblWelcome.Text = loginResponse.Nombre + " " + loginResponse.Apellido;
            }
            else
            {
                lblWelcome.Text = "No ha iniciado sesión";
            }
        }
    }
}