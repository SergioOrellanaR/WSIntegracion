﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DABBAWALLASEntities : DbContext
    {
        public DABBAWALLASEntities()
            : base("name=DABBAWALLASEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ALERTA> ALERTA { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<COMUNA> COMUNA { get; set; }
        public virtual DbSet<DABBAWALLA> DABBAWALLA { get; set; }
        public virtual DbSet<ESTADO_SUSCRIPCION> ESTADO_SUSCRIPCION { get; set; }
        public virtual DbSet<ESTADO_TICKET> ESTADO_TICKET { get; set; }
        public virtual DbSet<PROVINCIA> PROVINCIA { get; set; }
        public virtual DbSet<REGION> REGION { get; set; }
        public virtual DbSet<SUPERVISOR> SUPERVISOR { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TICKET> TICKET { get; set; }
        public virtual DbSet<TIPO_ALERTA> TIPO_ALERTA { get; set; }
        public virtual DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<ZONA> ZONA { get; set; }
        public virtual DbSet<VISTA_INFORMACION_CLIENTES_SUSCRITOS> VISTA_INFORMACION_CLIENTES_SUSCRITOS { get; set; }
        public virtual DbSet<VISTA_CANTIDAD_CLIENTES_POR_DABBAWALLA> VISTA_CANTIDAD_CLIENTES_POR_DABBAWALLA { get; set; }
        public virtual DbSet<VISTA_CANTIDAD_DABBAWALLAS_POR_SUPERVISOR> VISTA_CANTIDAD_DABBAWALLAS_POR_SUPERVISOR { get; set; }
    }
}
