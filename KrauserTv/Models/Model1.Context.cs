﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KrauserTv.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class krausertvEntities : DbContext
    {
        public krausertvEntities()
            : base("name=krausertvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblcapitulos> tblcapitulos { get; set; }
        public DbSet<tblcapituloservers> tblcapituloservers { get; set; }
        public DbSet<tblgeneros> tblgeneros { get; set; }
        public DbSet<tblpersonas> tblpersonas { get; set; }
        public DbSet<tblseriegenero> tblseriegenero { get; set; }
        public DbSet<tblserielike> tblserielike { get; set; }
        public DbSet<tblserienolike> tblserienolike { get; set; }
        public DbSet<tblseries> tblseries { get; set; }
        public DbSet<tblserieseguir> tblserieseguir { get; set; }
        public DbSet<tblservidores> tblservidores { get; set; }
        public DbSet<tbltemporadas> tbltemporadas { get; set; }
        public DbSet<tbltipocuentas> tbltipocuentas { get; set; }
        public DbSet<tblusuariofavoritoseries> tblusuariofavoritoseries { get; set; }
        public DbSet<tblusuarios> tblusuarios { get; set; }
    }
}
