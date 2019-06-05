using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models.Responses
{
    public class LoginResponse
    {
        public int IdTipoUsuario { get; set; }
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string JWT { get; set; }
    }
}