using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models
{
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool PropertiesAreNullOrEmpty()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                return true; 
            }
            return false;
        }
    }
}