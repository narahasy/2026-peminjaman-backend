using System.ComponentModel.DataAnnotations;

namespace _2026_peminjaman_backend.Models
{
    public class Peminjaman
    {
        public int Id { get; set; }
        
        [Required]
        public string NamaMahasiswa { get; set; } = string.Empty; 
        
        [Required]
        public string Ruangan { get; set; } = string.Empty; 

        public string Keperluan { get; set; } = string.Empty; 

        public DateTime Tanggal { get; set; } 
        
        public string Status { get; set; } = "Menunggu Persetujuan"; 
    }
}