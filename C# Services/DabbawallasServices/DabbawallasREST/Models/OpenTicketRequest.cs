using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models
{
    public class OpenTicketRequest
    {
        //Remover al trabajar con JWT
        public string UsernameClienteEnvia { get; set; }
        public string UsernameClienteRecibe { get; set; }
    }
}