using Microsoft.EntityFrameworkCore;
using _2026_peminjaman_backend.Models;

namespace _2026_peminjaman_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Peminjaman> Peminjaman { get; set; } 
    }
}