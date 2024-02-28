using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Resource> resources { get; set; }
        public DbSet<HomeWork> homeWorks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Student
            modelBuilder.Entity<Student>().Property(e => e.Name).HasMaxLength(100);
            modelBuilder.Entity<Student>().Property(e => e.Name).IsUnicode(true);
            modelBuilder.Entity<Student>().Property(e => e.PhoneNumber).HasMaxLength(10);
            modelBuilder.Entity<Student>().Property(e => e.PhoneNumber).IsUnicode(false);

            //Course
            modelBuilder.Entity<Course>().Property(e => e.Name).HasMaxLength(80);
            modelBuilder.Entity<Course>().Property(e => e.Name).IsUnicode(true);
            modelBuilder.Entity<Course>().Property(e => e.Description).IsUnicode(true);

            //Resource
            modelBuilder.Entity<Resource>().Property(e => e.Name).HasMaxLength(50);
            modelBuilder.Entity<Resource>().Property(e => e.Name).IsUnicode(true);
            modelBuilder.Entity<Resource>().Property(e => e.Url).IsUnicode(false);

            //HomeWork
            modelBuilder.Entity<HomeWork>().Property(e => e.Content).IsUnicode(false);
        }
    }
}
