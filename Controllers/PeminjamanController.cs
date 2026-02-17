using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _2026_peminjaman_backend.Data;
using _2026_peminjaman_backend.Models;
using _2026_peminjaman_backend.DTOs;

namespace _2026_peminjaman_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeminjamanController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PeminjamanController(AppDbContext context)
        {
            _context = context;
        }

        // 1. VIEW
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeminjamanDto>>> Get()
        {
            var data = await _context.Peminjaman.ToListAsync();
            return Ok(data.Select(x => new PeminjamanDto {
                Id = x.Id, 
                NamaMahasiswa = x.NamaMahasiswa, 
                Ruangan = x.Ruangan,
                Keperluan = x.Keperluan, 
                Tanggal = x.Tanggal, 
                Status = x.Status
            }));
        }

        // 2. CREATE
        [HttpPost]
        public async Task<ActionResult> Post(PeminjamanDto dto)
        {
            var item = new Peminjaman { 
                NamaMahasiswa = dto.NamaMahasiswa, 
                Ruangan = dto.Ruangan, 
                Keperluan = dto.Keperluan,
                Tanggal = dto.Tanggal, 
                Status = "Menunggu Persetujuan" 
            };  
            _context.Peminjaman.Add(item);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // 3. UPDATE
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PeminjamanDto dto)
        {
            var item = await _context.Peminjaman.FindAsync(id);
            if (item == null) return NotFound();

            item.NamaMahasiswa = dto.NamaMahasiswa;
            item.Ruangan = dto.Ruangan;
            item.Keperluan = dto.Keperluan;
            item.Tanggal = dto.Tanggal;
            item.Status = dto.Status; // Ini untuk Fitur 2 (Ubah Status)

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // 4. DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Peminjaman.FindAsync(id);
            if (item == null) return NotFound();

            _context.Peminjaman.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}