using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models.Responses
{
    public class AlertResponse
    {
        public int IdClienteAlerta { get; set; }
        public string UsernameClienteAlerta { get; set; }
        public int IdDabbawallaAlertado { get; set; }
        public string UsernameDabbawallaAlertado { get; set; }
        public int IdSupervisorRecibeAlerta { get; set; }
        public string UsernameSupervisorAlertado { get; set; }
        public string CelularSupervisorAlertado { get; set; }
        public string FechaInicioAlerta { get; set; }
    }
}