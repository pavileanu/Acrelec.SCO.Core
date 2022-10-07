using Acrelec.SCO.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acrelec.SCO.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasOne(o => o.Customer);

            builder.Entity<Order>()
                .HasMany(o => o.OrderItems);

        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=MyDb");*/
    }
}
