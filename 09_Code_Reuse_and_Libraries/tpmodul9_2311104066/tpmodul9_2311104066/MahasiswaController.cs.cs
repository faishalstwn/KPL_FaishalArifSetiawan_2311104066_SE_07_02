using Microsoft.AspNetCore.Mvc;
using tpmodul9_130220xxxx.Models;

namespace tpmodul9_130220xxxx.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Nama Kamu", Nim = "130220xxxx" },
            new Mahasiswa { Nama = "Teman A", Nim = "1302200002" },
            new Mahasiswa { Nama = "Teman B", Nim = "1302200003" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();

            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok("Mahasiswa berhasil ditambahkan");
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();

            daftarMahasiswa.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus");
        }
    }
}
