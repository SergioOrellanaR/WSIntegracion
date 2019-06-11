using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models
{
    public class RegisterDabbawallaRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        public bool PropertiesAreNullOrEmpty()
        {
            if (string.IsNullOrEmpty(Username) ||
                string.IsNullOrEmpty(Password) ||
                string.IsNullOrEmpty(Nombre) ||
                string.IsNullOrEmpty(Apellido) ||
                string.IsNullOrEmpty(Email) ||
                string.IsNullOrEmpty(Celular))
            {
                return true;
            }
            return false;
        }
    }
}