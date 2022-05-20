using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using TimeSheets.Controllers.Models;

namespace TimeSheets.DAL.Repositories.DataBase
{
    public class UserDbContext : DbContext
    {
        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Timesheets.Controllers.Models.Task> Tasks { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options)
         : base(options)
        {
            Database.EnsureCreated();
        }

        /*

        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            optionsBuilder
            .UseNpgsql("Host=vma-postgres;Database=vma;Username=vma;Password=K8YEW7nZHkX2+cvF; ");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contract>().Ignore(x => x.description);

            //modelBuilder.Entity<User>().Property(s => s.Id).HasColumnName("id");
            //modelBuilder.Entity<User>().Property(s => s.FirstName).HasColumnName("firstname");
            //modelBuilder.Entity<User>().Property(s => s.LastName).HasColumnName("lastname");
            //modelBuilder.Entity<User>().Property(s => s.MiddleName).HasColumnName("middlename");
            //modelBuilder.Entity<User>().Property(s => s.Comment).HasColumnName("comment");
            //modelBuilder.Entity<User>().Property(s => s.IsDeleted).HasColumnName("isdeleted");

        }
        */
    }
}

// "Postgres": {
//     "ConnectionString": "Server=host.docker.internal;Port=5432;Database=vma;User Id=vma;Password=K8YEW7nZHkX2+cvF;Search Path=vma;Command Timeout=0;Include Error Detail=true"
// },
// .UseNpgsql("Host=vma-postgres;Database=vma;Username=vma;Password=K8YEW7nZHkX2+cvF; ");