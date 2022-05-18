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
        public IActionResult SetFuncionarioNaLista(FuncionarioDTO funcionarioDto)
        {   var funcionario1 = new Funcionario(funcionarioDto.Nome,funcionarioDto.Cpf,funcionarioDto.DataNascimento,funcionarioDto.Cargo);
            FuncionariosDaClasseDTO.Add(funcionarioDto);
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