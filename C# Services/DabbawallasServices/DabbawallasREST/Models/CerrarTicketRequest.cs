using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models
{
    public class CerrarTicketRequest
    {
        public string Username { get; set; }
        public int Calificacion { get; set; }
    }
}