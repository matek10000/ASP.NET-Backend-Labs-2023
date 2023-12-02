using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductData.Entities;
using System;
using System.IO;

namespace ProductData
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        private string DbPath { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "products.db");
        }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductEntity>()
                .HasKey(p => p.Id);

            // TODO: Dodaj konfigurację modelu produktu, jeśli jest potrzebna.

            modelBuilder.Entity<ProductEntity>()
                .HasData(
                    // Dodaj dane testowe dla produktów
                    new ProductEntity { Id = 1, Name = "Product1", Price = 10.0m, Manufacturer = "Manufacturer1", ProductionDate = DateTime.Now, Description = "Description1" },
                    new ProductEntity { Id = 2, Name = "Product2", Price = 20.0m, Manufacturer = "Manufacturer2", ProductionDate = DateTime.Now, Description = "Description2" }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
