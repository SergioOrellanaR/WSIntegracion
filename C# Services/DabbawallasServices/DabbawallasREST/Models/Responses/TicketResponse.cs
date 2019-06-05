using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models.Responses
{
    public class TicketResponse
    {
        public int IdTicket { get; set; }
        public string FechaDeAperturaDeTicket { get; set; }
        public int IdClienteEnvia { get; set; }
        public string UsernameClienteEnvia { get; set; }
        public string DireccionHogarClienteEnvia { get; set; }
        public int IdComunaHogarClienteEnvia { get; set; }
        public string ComunaHogarClienteEnvia { get; set; }
        public int IdDabbawallaEncargado { get; set; }
        public string UsernameDabbawallaEncargado { get; set; }
        public int IdClienteRecibe { get; set; }
        public string UsernameClienteRecibe { get; set; }
        public string DireccionTrabajoClienteRecibe { get; set; }
        public int IdComunaTrabajoClienteRecibe { get; set; }
        public string ComunaTrabajoClienteRecibe { get; set; }

    }
}