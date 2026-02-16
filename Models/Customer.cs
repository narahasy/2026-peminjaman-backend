using System.ComponentModel.DataAnnotations;

namespace _2026_peminjaman_backend.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string Status { get; set; } = "Active";

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}