using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.DAL.Entities;

namespace TimeSheets
{
    public class UserDbContext : DbContext
    {
        public DbSet<Contract> Contracts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            optionsBuilder
            .UseNpgsql("Host=localhost;Database=vma;Username=vma;Password=K8YEW7nZHkX2+cvF; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contract>().Ignore(x => x.Description);
        }
    }
}
