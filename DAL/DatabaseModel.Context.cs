﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SearchEngineDBEntities : DbContext
    {
        public SearchEngineDBEntities()
            : base("name=SearchEngineDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<Terms> Terms { get; set; }
        public virtual DbSet<Contains> Contains { get; set; }
    }
}