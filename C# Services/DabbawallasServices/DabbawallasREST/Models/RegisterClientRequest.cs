using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models
{
    public class RegisterClientRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string DireccionHogar { get; set; }
        public string DireccionTrabajo { get; set; }
        public int IdComunaHogar { get; set; }
        public int IdComunaTrabajo { get; set; }
        public int IdDabbawalla { get; set; }
    }
}