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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.CLIENTE = new HashSet<CLIENTE>();
            this.DABBAWALLA = new HashSet<DABBAWALLA>();
            this.SUPERVISOR = new HashSet<SUPERVISOR>();
        }
    
        public int ID_USUARIO { get; set; }
        public Nullable<int> ID_TIPO_USUARIO { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string EMAIL { get; set; }
        public string CELULAR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DABBAWALLA> DABBAWALLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPERVISOR> SUPERVISOR { get; set; }
        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
    }
}
