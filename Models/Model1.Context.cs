﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GariLagbe.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class garilagbeEntities1 : DbContext
    {
        public garilagbeEntities1()
            : base("name=garilagbeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ContactU> ContactUS { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerStatu> CustomerStatus { get; set; }
        public virtual DbSet<OrderM> OrderMs { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
    }
}
