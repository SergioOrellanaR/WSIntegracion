using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models
{
    public class CloseTicketRequest
    {
        public string Username { get; set; }
        public int Calificacion { get; set; }
    }
}