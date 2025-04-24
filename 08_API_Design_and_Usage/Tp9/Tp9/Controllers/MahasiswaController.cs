using Microsoft.AspNetCore.Mvc;
using tp9.Models;

namespace Tp9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        
        private static readonly List<Mahasiswa> Mahasiswas = new()
        {
            new Mahasiswa { Nama = "Faishal Arif Setiawan", NIM = "2311104066" },
            new Mahasiswa { Nama = "Supri", NIM = "231110490" }
        };

        // GET: api/mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return Ok(Mahasiswas);
        }

        // GET: api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= Mahasiswas.Count)
                return NotFound($"Mahasiswa dengan index {index} tidak ditemukan.");

            return Ok(Mahasiswas[index]);
        }

        // POST: api/mahasiswa
        [HttpPost]
        public ActionResult Add([FromBody] Mahasiswa newMhs)
        {
            if (string.IsNullOrWhiteSpace(newMhs.Nama) || string.IsNullOrWhiteSpace(newMhs.NIM))
                return BadRequest("Nama dan NIM wajib diisi.");

            Mahasiswas.Add(newMhs);
            return Ok($"Mahasiswa '{newMhs.Nama}' berhasil ditambahkan.");
        }

        // DELETE: api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= Mahasiswas.Count)
                return NotFound($"Mahasiswa dengan index {index} tidak ditemukan.");

            var removed = Mahasiswas[index];
            Mahasiswas.RemoveAt(index);
            return Ok($"Mahasiswa '{removed.Nama}' berhasil dihapus.");
        }
    }
}