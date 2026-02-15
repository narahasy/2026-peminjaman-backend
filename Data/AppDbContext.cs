using Microsoft.EntityFrameworkCore;
using _2026_Peminjaman_backend.Models;

namespace _2026_Peminjaman_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}