using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OwnedEntityDelete
{
    public class TestContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TestDb;Trusted_Connection=True;");
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .OwnsOne(x => x.ShippingAddress, w =>
                {
                    w.Property(x => x.City).HasMaxLength(100);
                    w.Property(x => x.Street).HasMaxLength(100);
                });
        }
    }

    public class StreetAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public StreetAddress ShippingAddress { get; set; }
    }
}
