using System;
using Microsoft.EntityFrameworkCore;
using VendingMachine.Models;

namespace VendingMachine {
    public class AppDbContext : DbContext {
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodToMachine> GoodToMachine { get; set; }
        
        public AppDbContext() {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=89372908085hfvbkm;database=vendingmachines;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }
    }
}