using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.P02_SalesDatabase.Data
{
    internal class SalesContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Sales;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Product
            modelBuilder.Entity<Product>().Property(e => e.Name).HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(e => e.Name).IsUnicode(true);
            modelBuilder.Entity<Product>().Property(e => e.Description).HasMaxLength(250);
            modelBuilder.Entity<Product>().Property(e => e.Description).HasDefaultValue("No Description");

            //Customer
            modelBuilder.Entity<Customer>().Property(e => e.Name).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(e => e.Name).IsUnicode(true);
            modelBuilder.Entity<Customer>().Property(e => e.email).HasMaxLength(80);
            modelBuilder.Entity<Customer>().Property(e => e.email).IsUnicode(false);

            //Store
            modelBuilder.Entity<Store>().Property(e => e.Name).HasMaxLength(80);
            modelBuilder.Entity<Store>().Property(e => e.Name).IsUnicode(true);

            //Sale
            modelBuilder.Entity<Sale>().Property(e => e.Date).HasDefaultValueSql("getdate()");
        }

    }
}
