﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entitornek
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbSinavOgrenciEntities : DbContext
    {
        public DbSinavOgrenciEntities()
            : base("name=DbSinavOgrenciEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<derslertablo> derslertablo { get; set; }
        public virtual DbSet<notlartablo> notlartablo { get; set; }
        public virtual DbSet<ogrencitablo> ogrencitablo { get; set; }
    }
}
