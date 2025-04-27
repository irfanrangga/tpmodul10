using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_103022300100.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static readonly List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Irfan Rangga", "103022300100"),
            new Mahasiswa("Riza Muhammad", "103022300104"),
            new Mahasiswa("Tubagus Aulia", "103022300141"),
            new Mahasiswa("Gamaliel Pradana", "103022300015"),
            new Mahasiswa("Muhammad Razky", "103022300047"),
            new Mahasiswa("Christofer Abel", "103022330039")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{index}")]
        public Mahasiswa Get(int index)
        {
            return mahasiswaList[index];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswaList.Add(value);
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            mahasiswaList.RemoveAt(index);
        }
    }
}
