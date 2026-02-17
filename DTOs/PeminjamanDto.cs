namespace _2026_peminjaman_backend.DTOs
{
    public class PeminjamanDto
    {
        public int Id { get; set; }
        public string NamaMahasiswa { get; set; } = string.Empty;
        public string Ruangan { get; set; } = string.Empty;
        public string Keperluan { get; set; } = string.Empty;
        public DateTime Tanggal { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}