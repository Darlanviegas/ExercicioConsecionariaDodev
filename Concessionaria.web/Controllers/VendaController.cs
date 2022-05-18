using Microsoft.AspNetCore.Mvc;
using Concessionaria.web.DTOs;
using Exercicio_Concessionaria.Models;
namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        public static List<VendaDTO> VendasDaClasseDTO { get; set; } = new List<VendaDTO>();

        [HttpGet("Get VendasDaLista")]
        public IActionResult GetVendasDaLista()
        {
            return Ok(VendasDaClasseDTO);
        }

        [HttpPost("Set VendaNaLista")]
        public IActionResult SetVendaNaLista(VendaDTO venda)
        {
            var comprador1 = new Cliente(venda.Comprador.Nome,venda.Comprador.Cpf,venda.Comprador.DataNascimento,venda.Comprador.Email,venda.Comprador.Telefone);
            var funcionario1 = new Funcionario(venda.Vendedor.Nome,venda.Vendedor.Cpf,venda.Vendedor.DataNascimento,venda.Vendedor.Cargo);
            var veiculo1 = new Veiculo(venda.Veiculo.Marca,venda.Veiculo.Modelo,venda.Veiculo.Ano,venda.Veiculo.Kilometragem,venda.Veiculo.Cor,venda.Veiculo.Valor);
            VendasDaClasseDTO.Add(venda);
            return Ok(VendasDaClasseDTO);
        }

        [HttpDelete("Delete VendaDaLista")]
        public IActionResult DeleteVendaDaLista()
        {
            VendasDaClasseDTO.RemoveAt(VendasDaClasseDTO.Count - 1);
            return Ok(VendasDaClasseDTO);
        }
    }
}