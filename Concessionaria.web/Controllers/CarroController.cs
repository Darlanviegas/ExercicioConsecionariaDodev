using Microsoft.AspNetCore.Mvc;
using Concessionaria.web.DTOs;
using Exercicio_Concessionaria.Models;
namespace Concessionaria.web.Controllers{
    
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        public static List<CarroDTO> CarrosDaClasseDTO { get; set; } = new List<CarroDTO>();

        [HttpGet("Get CarrosDaLista")]
        public IActionResult GetCarrosDaLista()
        {
            return Ok(CarrosDaClasseDTO);
        }

        [HttpPost("Set CarroNaLista")]
        public IActionResult SetCarroNaLista(CarroDTO carroDto)
        {   var carro = new Carro(carroDto.Marca,carroDto.Modelo,carroDto.Ano,carroDto.Kilometragem,carroDto.Cor,carroDto.Valor,carroDto.TransmissaoAutomatica,carroDto.Combustivel);
            CarrosDaClasseDTO.Add(carroDto);
            return Ok(CarrosDaClasseDTO);
        }

        [HttpDelete("Delete CarroDaLista")]
        public IActionResult DeleteCarroDaLista()
        {
            CarrosDaClasseDTO.RemoveAt(CarrosDaClasseDTO.Count - 1);
            return Ok(CarrosDaClasseDTO);
        }
    }
}