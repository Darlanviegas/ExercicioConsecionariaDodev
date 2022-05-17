using Microsoft.AspNetCore.Mvc;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        public static List<MotoDTO> MotosDaClasseDTO { get; set; } = new List<MotoDTO>();

        [HttpGet("Get MotosDaLista")]
        public IActionResult GetMotosDaLista()
        {
            return Ok(MotosDaClasseDTO);
        }

        [HttpPost("Set MotoNaLista")]
        public IActionResult SetMotoNaLista(MotoDTO moto)
        {
            MotosDaClasseDTO.Add(moto);
            return Ok(MotosDaClasseDTO);
        }

        [HttpDelete("Delete MotoDaLista")]
        public IActionResult DeleteMotoDaLista()
        {
            MotosDaClasseDTO.RemoveAt(MotosDaClasseDTO.Count - 1);
            return Ok(MotosDaClasseDTO);
        }

    }
}