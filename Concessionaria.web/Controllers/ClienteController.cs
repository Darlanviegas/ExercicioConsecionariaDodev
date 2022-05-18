using Microsoft.AspNetCore.Mvc;
using Concessionaria.web.DTOs;
using Exercicio_Concessionaria.Models;
namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        public static List<ClienteDTO> ClientesdaClasseDTO { get; set; } = new List<ClienteDTO>();

        [HttpGet("Get ClientesDaLista")]
        public IActionResult GetClientesDaLista()
        {
            return Ok(ClientesdaClasseDTO);
        }

        [HttpPost("Set ClienteNaLista")]
        public IActionResult SetClienteNaLista(ClienteDTO clienteDto)
        {   var cliente1 = new Cliente(clienteDto.Nome,clienteDto.Cpf,clienteDto.DataNascimento,clienteDto.Email,clienteDto.Telefone);
            ClientesdaClasseDTO.Add(clienteDto);
            return Ok(ClientesdaClasseDTO);
        }

        [HttpDelete("Delete ClienteDaLista")]
        public IActionResult DeleteClienteDaLista()
        {
            ClientesdaClasseDTO.RemoveAt(ClientesdaClasseDTO.Count - 1);
            return Ok(ClientesdaClasseDTO);
        }
    }
}