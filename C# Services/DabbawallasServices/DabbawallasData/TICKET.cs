//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DabbawallasData
{
    using System;
    using System.Collections.Generic;
    
    public partial class TICKET
    {
        public int ID_TICKET { get; set; }
        public Nullable<int> ID_CLIENTE_ENVIA { get; set; }
        public Nullable<int> ID_CLIENTE_RECIBE { get; set; }
        public Nullable<int> ID_ESTADO { get; set; }
        public Nullable<System.DateTime> FECHA_APERTURA { get; set; }
        public Nullable<System.DateTime> FECHA_CLAUSURA { get; set; }
        public int CALIFICACION_SERVICIO { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual CLIENTE CLIENTE1 { get; set; }
        public virtual ESTADO_TICKET ESTADO_TICKET { get; set; }
    }
}
