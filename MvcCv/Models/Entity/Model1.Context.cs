﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities : DbContext
    {
        public DbCvEntities()
            : base("name=DbCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TabloAdmin> TabloAdmin { get; set; }
        public virtual DbSet<TabloDeneyim> TabloDeneyim { get; set; }
        public virtual DbSet<TabloEgitim> TabloEgitim { get; set; }
        public virtual DbSet<TabloHakkimda> TabloHakkimda { get; set; }
        public virtual DbSet<TabloHobi> TabloHobi { get; set; }
        public virtual DbSet<Tabloiletisim> Tabloiletisim { get; set; }
        public virtual DbSet<TabloSertifika> TabloSertifika { get; set; }
        public virtual DbSet<TabloYetenek> TabloYetenek { get; set; }
        public virtual DbSet<TabloSosyalMedya> TabloSosyalMedya { get; set; }
        public virtual DbSet<TabloPortfolyo> TabloPortfolyo { get; set; }
    }
}
