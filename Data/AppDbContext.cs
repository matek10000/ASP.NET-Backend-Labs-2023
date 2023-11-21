using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "contacts.db");
        }
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();

            //Tworzenie uzytkownika
            var user = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "mateusz",
                Email = "mateusz.dybas@gmail.com",
                EmailConfirmed = true,
            };
            //Hashowanie hasla
            user.PasswordHash = ph.HashPassword(user, "Start123!");

            //Prypisanie uzytkownika do Buildera
            modelBuilder.Entity<IdentityUser>()
                .HasData(
                    user
                );

            //Tworzenie roli
            var adminRole = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "admin",
                NormalizedName = "ADMIN"
            };

            //Przypisanie roli do Buildera
            adminRole.ConcurrencyStamp = adminRole.Id;
            modelBuilder.Entity<IdentityRole>()
                .HasData(
                    adminRole
                );

            // Prypisanie roli do uzytkownika
            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>()
                    {
                        RoleId = adminRole.Id,
                        UserId = user.Id
                    }
                );

            modelBuilder.Entity<ContactEntity>()
                .HasOne(c => c.Organizations)
                .WithMany(o => o.Contacts)
                .HasForeignKey(c => c.OrganizationId);

            modelBuilder.Entity<OrganizationEntity>()
                .HasData(
                new OrganizationEntity()
                {
                    Id = 1,
                    Name = "WSEI",
                    Description = "Uczelnia wyższa w Krakowie"
                }
                );

            modelBuilder.Entity<ContactEntity>()
                .HasData(
                new ContactEntity() {
                    ContactId = 1,
                    Name = "Adam",
                    Email = "adam@wsei.edu.pl",
                    Phone = "127813268163",
                    Birth = new DateTime(2000, 10, 10) ,
                    OrganizationId = 1},
                new ContactEntity() {
                    ContactId = 2,
                    Name = "Ewa",
                    Email = "ewa@wsei.edu.pl",
                    Phone = "293443823478",
                    Birth = new DateTime(1999, 8, 10),
                    OrganizationId = 1}
        );
            modelBuilder.Entity<OrganizationEntity>()
                .OwnsOne(o => o.Address)
                .HasData(
                new { OrganizationEntityId = 1, City = "Kraków", Street = "Św. Filipa 17", PostalCode = "31-150" }
                );


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
