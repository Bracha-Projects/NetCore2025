
using Microsoft.EntityFrameworkCore;
using MishnatYosef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MishnatYosef.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DistibutionStation> DistributionStations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderedProduct> OrderedProducts { get; set; }
        public DbSet<ProductOnSell> ProductsOnSell { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DistibutionStation>().HasKey(d => d.Id);
        }

    }
}
