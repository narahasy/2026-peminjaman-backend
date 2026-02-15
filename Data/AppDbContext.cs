using Microsoft.EntityFrameworkCore;
using _2026_Peminjaman_backend.Models;

namespace _2026_Peminjaman_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Data Seeding (Langkah 6)
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Admin", Email = "admin@mail.com", Status = "active" },
                new Customer { Id = 2, Name = "Budi Raharjo", Email = "budiraharjo@mail.com", Status = "active" },
                new Customer { Id = 3, Name = "Siti Aminah", Email = "sitiaminah@mail.com", Status = "inactive" }
            );
        }
    }
}