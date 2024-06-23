using Accessibility;
using laba_6.Classes.PC_SetUp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal class Context : DbContext
    {
        //public DbSet<PC> Configurators { get; set; } = null!;
        public DbSet<Configurator> Configurators { get; set; } = null!;

        public Context(): base()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ServicePCClass());
            //modelBuilder.Entity<Test>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
