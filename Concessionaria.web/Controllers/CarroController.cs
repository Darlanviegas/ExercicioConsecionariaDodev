using Microsoft.AspNetCore.Mvc;
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
        public IActionResult SetCarroNaLista(CarroDto carro)
        {   var carro = new Carro(carroDTO.Marca,carroDTO.Modelo,carroDTO.Ano.ToString(),carroDTO.Kilometragem,carroDTO.Cor,carroDTO.Valor);
            CarrosDaClasseDTO.Add(carroDTO);
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