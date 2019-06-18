using DabbawallasBusiness.Classes;
using DabbawallasREST.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DabbawallaView
{
    public partial class Informacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                LoginResponse user = DeserealizeSesion();
                lblDataNombre.Text = user.Nombre + " " + user.Apellido;
                switch (user.IdTipoUsuario)
                {
                    case 1:
                        Cliente client = new Cliente(user.IdTipoUsuario);
                        lblDataRol.Text = "Cliente";
                        lblDataDabEncargado.Text = client.DabbawallaAsociado.Nombre + " " + client.DabbawallaAsociado.Apellido;
                        lblDataSupEncargado.Text = client.DabbawallaAsociado.SupervisorAsociado.Nombre + " " + client.DabbawallaAsociado.SupervisorAsociado.Apellido;
                        lblDataDirHog.Text = client.DireccionHogar;
                        lblDataDirTra.Text = client.DireccionTrabajo;
                        break;
                    case 2:
                        Dabbawalla dab = new Dabbawalla(user.IdTipoUsuario);
                        lblDataRol.Text = "Dabbawalla";
                        lblDireccionHogar.Visible = false;
                        lblDireccionTrabajo.Visible = false;
                        lblDabbawallaEncargado.Visible = false;
                        lblDataSupEncargado.Text = dab.SupervisorAsociado.Nombre + " " + dab.SupervisorAsociado.Apellido;
                        break;
                    case 3:
                        lblDataRol.Text = "Supervisor";
                        lblDireccionHogar.Visible = false;
                        lblDireccionTrabajo.Visible = false;
                        lblDabbawallaEncargado.Visible = false;
                        lblSupervisorEncargado.Visible = false;
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
    }
}