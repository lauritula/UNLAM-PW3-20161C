﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PW3_TP_20161CEntities : DbContext
    {
        public PW3_TP_20161CEntities()
            : base("name=PW3_TP_20161CEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Recetas> Recetas { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}