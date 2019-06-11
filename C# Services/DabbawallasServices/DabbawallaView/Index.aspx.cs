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
    public partial class Index : System.Web.UI.Page
    {
        RESTWebCaller caller = new RESTWebCaller();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    if (Session["ses"] != null)
            //    {
            //        LoginResponse user = (LoginResponse)Session["ses"];
            //        switch (user.IdTipoUsuario)
            //        {
            //            case 1:
            //                navbarCliente = true;
            //                navbarDabbawea = false;
            //                navbarSupervisor = false;
            //                navbarDefault = false;
            //                break;
            //            case 2:
            //                navbarCliente = false;
            //                navbarDabbawea = true;
            //                navbarSupervisor = false;
            //                navbarDefault = false;
            //                break;
            //            case 3:
            //                navbarCliente = false;
            //                navbarDabbawea = false;
            //                navbarSupervisor = true;
            //                navbarDefault = false;
            //            default:
            //                navbarCliente = false;
            //                navbarDabbawea = false;
            //                navbarSupervisor = false;
            //                navbarDefault = true;
            //                break;
            //        }
            //    }
            //    else
            //    {

            //    }
            //}
        }

        protected void Login(object sender, EventArgs e)
        {
            string loginURL = "http://localhost:6970/dabbawallas/login/authenticate";

            LoginRequest loginRequest = new LoginRequest()
            {
                Username = txUser.Text,
                Password = txPass.Text
            };

            string jsonRequest = JsonConvert.SerializeObject(loginRequest);
            string jsonResponse = caller.MethodCallerPOST(loginURL, jsonRequest);

            if (jsonResponse != null)
            {
                LoginResponse loginResponse = JsonConvert.DeserializeObject<LoginResponse>(jsonResponse);
                Session["ses"] = loginResponse;
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}