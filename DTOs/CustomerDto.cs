using _2026_Peminjaman_backend.DTOs;

namespace _2026_Peminjaman_backend.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Status { get; set; }
    }
}