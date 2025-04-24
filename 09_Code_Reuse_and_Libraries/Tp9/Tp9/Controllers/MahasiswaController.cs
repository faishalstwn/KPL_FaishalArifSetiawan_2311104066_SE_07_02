using Microsoft.AspNetCore.Mvc; // Menggunakan directive yang benar
using Tp9.Models; // Pastikan nama namespace yang benar

namespace Tp9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        // Menyimpan data mahasiswa dalam list statis
        private static readonly List<Mahasiswa> Mahasiswas = new()
        {
            new Mahasiswa { Nama = "Faishal Arif Setiawan", NIM = "2311104066" },
            new Mahasiswa { Nama = "Supri", NIM = "231110490" }
        };

        // GET: api/mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return Ok(Mahasiswas); // Mengembalikan semua data mahasiswa
        }

        // GET: api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= Mahasiswas.Count)
                return NotFound($"Mahasiswa dengan index {index} tidak ditemukan.");

            return Ok(Mahasiswas[index]); // Mengembalikan mahasiswa berdasarkan index
        }

        // POST: api/mahasiswa
        [HttpPost]
        public ActionResult Add([FromBody] Mahasiswa newMhs)
        {
            if (string.IsNullOrWhiteSpace(newMhs.Nama) || string.IsNullOrWhiteSpace(newMhs.NIM))
                return BadRequest("Nama dan NIM wajib diisi."); // Validasi data yang masuk

            Mahasiswas.Add(newMhs); // Menambahkan mahasiswa baru ke list
            return Ok($"Mahasiswa '{newMhs.Nama}' berhasil ditambahkan.");
        }

        // DELETE: api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= Mahasiswas.Count)
                return NotFound($"Mahasiswa dengan index {index} tidak ditemukan.");

            var removed = Mahasiswas[index];
            Mahasiswas.RemoveAt(index); // Menghapus mahasiswa berdasarkan index
            return Ok($"Mahasiswa '{removed.Nama}' berhasil dihapus.");
        }
    }
}
