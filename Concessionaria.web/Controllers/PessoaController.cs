using Microsoft.AspNetCore.Mvc;
using Concessionaria.web.DTOs;
using Exercicio_Concessionaria.Models;
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
        public IActionResult SetPessoaDaClasse(PessoaDTO pessoaDto)
        {   var pessoa1 = new Pessoa(pessoaDto.Nome,pessoaDto.Cpf,pessoaDto.DataNascimento);
            PessoasDaClasseDTO.Add(pessoaDto);
            return Ok(PessoasDaClasseDTO);
        }
    }
}