using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DabbawallasREST.Models;
using DabbawallasBusiness.Classes;
using DabbawallaView.Classes;
using DabbawallasREST.Models.Responses;
using Newtonsoft.Json;

namespace DabbawallaView
{
    public partial class RegistroSupervisor : System.Web.UI.Page
    {
        RESTWebCaller caller = new RESTWebCaller();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlZonas.DataSource = new List<string> { "A", "B", "C" };
            ddlZonas.DataBind();
        }

        protected void Register(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string registerUrl = "http://localhost:6970/dabbawallas/register/supervisor";

                RegisterSupervisorRequest RegisterRequest = new RegisterSupervisorRequest()
                {
                    Nombre = txNombre.Text,
                    Apellido = txApellido.Text,
                    Celular = txCelular.Text,
                    Email = txEmail.Text,
                    Username = txUsername.Text,
                    Password = txPassword.Text,
                    Zona = ddlZonas.SelectedValue
                };

                string jsonRequest = JsonConvert.SerializeObject(RegisterRequest);
                string jsonResponse = caller.MethodCallerPOST(registerUrl, jsonRequest);

                if (jsonResponse != null)
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    Response.Redirect("www.google.cl");
                }
            }
        }
    }
}