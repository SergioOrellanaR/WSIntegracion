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
    public partial class DabbawallasMasterpage : System.Web.UI.MasterPage
    {
        RESTWebCaller caller = new RESTWebCaller();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                Response.Redirect("IndexLog.aspx");
            }
        }

        protected void Login(object sender, EventArgs e)
        {

            //if (Page.IsValid)
            //{
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
                    Response.Redirect("IndexLog.aspx");
                }
                else
                {
                    Response.Redirect("Index.aspx");
                }
            //}
            //else
            //{

            //}
        }

        protected bool IsGroupValid(string sValidationGroup)
        {
            foreach (BaseValidator validator in Page.Validators)
            {
                if (validator.ValidationGroup == sValidationGroup)
                {
                    bool fValid = validator.IsValid;
                    if (fValid)
                    {
                        validator.Validate();
                        fValid = validator.IsValid;
                        validator.IsValid = true;
                    }
                    if (!fValid)
                        return false;
                }

            }
            return true;
        }
    }
}