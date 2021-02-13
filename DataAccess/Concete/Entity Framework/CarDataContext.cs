using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Color = Entities.Concrete.Color;

namespace DataAccess.Concete.Entity_Framework
{
    public class CarDataContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SQL server'ına bağlandığımız kod satırı
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarData;Trusted_Connection=true");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
