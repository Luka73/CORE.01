using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
using Project.Infrastructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Infrastructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StockConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
