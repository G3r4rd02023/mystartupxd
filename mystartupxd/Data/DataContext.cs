using Microsoft.EntityFrameworkCore;
using mystartupxd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mystartupxd.Data
{
    public class DataContext:DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }       
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique();
        }
        
    }
}
