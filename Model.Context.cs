﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjFinanzasPersonales
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDFinanzasPersonalesEntities : DbContext
    {
        public BDFinanzasPersonalesEntities()
            : base("name=BDFinanzasPersonalesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Egresos> Egresos { get; set; }
        public virtual DbSet<EstadoTransaccion> EstadoTransaccion { get; set; }
        public virtual DbSet<Ingresos> Ingresos { get; set; }
        public virtual DbSet<ProcesoCorte> ProcesoCorte { get; set; }
        public virtual DbSet<TipoEgreso> TipoEgreso { get; set; }
        public virtual DbSet<TipoIngreso> TipoIngreso { get; set; }
        public virtual DbSet<TipoPago> TipoPago { get; set; }
        public virtual DbSet<TipoPersona> TipoPersona { get; set; }
        public virtual DbSet<TipoTransaccion> TipoTransaccion { get; set; }
        public virtual DbSet<Transacciones> Transacciones { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}