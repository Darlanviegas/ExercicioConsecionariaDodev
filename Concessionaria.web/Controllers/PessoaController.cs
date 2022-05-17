using Microsoft.AspNetCore.Mvc;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        public static List<PessoaDTO> PessoasDaClasseDTO { get; set; } = new List<PessoaDTO>();

        [HttpGet("Get PessoaDaClasse")]
        public IActionResult GetPessoaDaClasse()
        {
            return Ok(PessoasDaClasseDTO);
        }

        [HttpPost("Set PessoaDaClasse")]
        public IActionResult SetPessoaDaClasse(PessoaDTO pessoa)
        {
            PessoasDaClasseDTO.Add(pessoa);
            return Ok(PessoasDaClasseDTO);
        }
    }
}