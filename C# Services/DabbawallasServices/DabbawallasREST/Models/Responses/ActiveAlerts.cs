using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models.Responses
{
    public class ActiveAlerts
    {
        [System.ComponentModel.DisplayName("ID")]
        public string IdAlerta { get; set; }

        [System.ComponentModel.DisplayName("Fecha de alerta")]
        public string FechaAlerta { get; set; }

        [System.ComponentModel.DisplayName("Cliente")]
        public string UsernameClienteAlerta { get; set; }

        [System.ComponentModel.DisplayName("Dirección de cliente")]
        public string DireccionHogar { get; set; }

        [System.ComponentModel.DisplayName("Comuna")]
        public string ComunaHogar { get; set; }

        [System.ComponentModel.DisplayName("Dabbawalla Encargado")]
        public string UsernameDabbawallaAlertado { get; set; }

        [System.ComponentModel.DisplayName("Celular dabbawalla")]
        public string CelularDabbawallaAlertado { get; set; }
    }
}