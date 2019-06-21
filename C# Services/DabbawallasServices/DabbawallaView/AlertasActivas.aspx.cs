using System;
using System.Collections.Generic;
using DabbawallasBusiness.Classes;
using DabbawallasREST.Models;
using DabbawallasREST.Models.Responses;
using DabbawallaView.Classes;
using Newtonsoft.Json;

namespace DabbawallaView
{
    public partial class AlertasActivas : System.Web.UI.Page
    {
        RESTWebCaller caller = new RESTWebCaller();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                LoginResponse user = DeserealizeSesion();
                switch (user.IdTipoUsuario)
                {
                    case 3:
                        LoadDataGrid(user);
                        break;
                    default:
                        Response.Redirect("IndexLog.aspx");
                        break;
                }
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }

        private List<ActiveAlerts> LoadActiveAlerts(LoginResponse user)
        {
            string registerUrl = "http://localhost:6969/alertasActivas";
            GenericClientRequest activateRequest = new GenericClientRequest()
            {
                Username = user.Username
            };

            string jsonRequest = JsonConvert.SerializeObject(activateRequest);
            string jsonResponse = caller.MethodCallerPOST(registerUrl, jsonRequest);
            List<ActiveAlerts> response = new List<ActiveAlerts>();

            if (jsonResponse != null)
            {
                response = JsonConvert.DeserializeObject<List<ActiveAlerts>>(jsonResponse);
            }
            else
            {
                lblMensajeVacio.Visible = true;
            }

            return response;
        }

        private LoginResponse DeserealizeSesion()
        {
            return (LoginResponse)Session["ses"];
        }

        private void LoadDataGrid(LoginResponse user)
        {
            grdAlertasActivas.DataSource = LoadActiveAlerts(user);
            grdAlertasActivas.DataBind();
            //if (grdAlertasActivas.Columns[0] != null)
            //    grdAlertasActivas.Columns[0].HeaderText = "ID";
            //if (grdAlertasActivas.Columns[1] != null)
            //    grdAlertasActivas.Columns[1].HeaderText = "Fecha de alerta";
            //if (grdAlertasActivas.Columns[2] != null)
            //    grdAlertasActivas.Columns[2].HeaderText = "Cliente";
            //if (grdAlertasActivas.Columns[3] != null)
            //    grdAlertasActivas.Columns[3].HeaderText = "Dirección de cliente";
            //if (grdAlertasActivas.Columns[4] != null)
            //    grdAlertasActivas.Columns[4].HeaderText = "Comuna";
            //if (grdAlertasActivas.Columns[5] != null)
            //    grdAlertasActivas.Columns[5].HeaderText = "Dabbawalla Encargado";
            //if (grdAlertasActivas.Columns[6] != null)
            //    grdAlertasActivas.Columns[6].HeaderText = "Celular dabbawalla";

        }
    }
}