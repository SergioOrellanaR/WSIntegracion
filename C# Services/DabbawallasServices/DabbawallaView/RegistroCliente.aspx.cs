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
    public partial class RegistroCliente : System.Web.UI.Page
    {
        Comuna comune = new Comuna();
        RESTWebCaller caller = new RESTWebCaller();

        protected void Page_Load(object sender, EventArgs e)
        {
            ddlComunaHogar.DataSource = comune.ListAllComunasNames();
            ddlComunaTrabajo.DataSource = new List<string> {"Providencia"};
            ddlComunaHogar.DataBind();
            ddlComunaTrabajo.DataBind();
        }

        protected void Register(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string registerUrl = "http://localhost:6970/dabbawallas/register/cliente";
                Comuna HomeComuna = new Comuna(ddlComunaHogar.Text);
                Comuna WorkComuna = new Comuna(ddlComunaTrabajo.Text);

                RegisterClientRequest RegisterRequest = new RegisterClientRequest()
                {
                    Nombre = txNombre.Text,
                    Apellido = txApellido.Text,
                    Celular = txCelular.Text,
                    Email = txEmail.Text,
                    DireccionHogar = txDireccionHogar.Text,
                    DireccionTrabajo = txDireccionTrabajo.Text,
                    Username = txUsername.Text,
                    Password = txPassword.Text,
                    IdComunaHogar = HomeComuna.IdComuna,
                    IdComunaTrabajo = WorkComuna.IdComuna
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