using Microsoft.AspNetCore.Mvc;
using Concessionaria.web.DTOs;
using Exercicio_Concessionaria.Models;
namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public static List<FuncionarioDTO> FuncionariosDaClasseDTO { get; set; } = new List<FuncionarioDTO>();

        [HttpGet("Get FuncionariosDaLista")]
        public IActionResult GetFuncionariosDaLista()
        {
            return Ok(FuncionariosDaClasseDTO);
        }

        [HttpPost("Set FuncionarioNaLista")]
        public IActionResult SetFuncionarioNaLista(FuncionarioDTO funcionario)
        {
            FuncionariosDaClasseDTO.Add(funcionario);
            return Ok(FuncionariosDaClasseDTO);
        }

        [HttpDelete("Delete FuncionarioDaLista")]
        public IActionResult DeleteFuncionarioDaLista()
        {
            FuncionariosDaClasseDTO.RemoveAt(FuncionariosDaClasseDTO.Count - 1);
            return Ok(FuncionariosDaClasseDTO);
        }
    }
}