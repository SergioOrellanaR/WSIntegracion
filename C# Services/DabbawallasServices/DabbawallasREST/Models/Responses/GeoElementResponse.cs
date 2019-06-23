using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DabbawallasREST.Models.Responses
{
    public class GeoElementResponse
    {
        public Hogar Hogar { get; set; }
        public Trabajo Trabajo { get; set; }
    }

    public class Hogar
    {
        public bool Success { get; set; }
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
    }

    public class Trabajo
    {
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
    }
}