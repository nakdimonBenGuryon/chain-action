using chinasA.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BSD.Models;

namespace BSD.DAL
{
    public class Context : DbContext
    {
        public DbSet<Admanistrator> Admanistrators { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Gift> Gifts { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Donation> Donations { get; set; }

        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Admanistrator>().Property(c=>c.Id)
            modelBuilder.Entity<Admanistrator>().Property(c => c.Id).UseIdentityColumn(0, 1);

            modelBuilder.Entity<Card>().Property(c => c.Id).UseIdentityColumn(0, 1);
            modelBuilder.Entity<Category>().Property(c => c.Id).UseIdentityColumn(370, 3);
            modelBuilder.Entity<Customer>().Property(c => c.Id).UseIdentityColumn(1025, 4);
            modelBuilder.Entity<Gift>().Property(c => c.Id).UseIdentityColumn(4545, 2);
            modelBuilder.Entity<Purchase>().Property(c => c.Id).UseIdentityColumn(71, 1);
            modelBuilder.Entity<Donation>().Property(c => c.Id).UseIdentityColumn(71, 1);
            modelBuilder.Entity<Gift>().Property(p => p.Price).HasColumnType("decimal(6,2)");
            modelBuilder.Entity<Card>().Property(p => p.Price).HasColumnType("decimal(6,2)");
            base.OnModelCreating(modelBuilder);
        }


    }
}
