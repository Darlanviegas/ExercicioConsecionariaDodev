using Microsoft.AspNetCore.Mvc;
namespace Concessionaria.web.Controllers{
    
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        public static List<Carro> CarrosDaClasse { get; set; } = new List<Carro>();

        [HttpGet("Get CarrosDaLista")]
        public IActionResult GetCarrosDaLista()
        {
            return Ok(CarrosDaClasse);
        }

        [HttpPost("Set CarroNaLista")]
        public IActionResult SetCarroNaLista(CarroDto carro)
        {
            CarrosDaClasse.Add(carro);
            return Ok(CarrosDaClasse);
        }

        [HttpDelete("Delete CarroDaLista")]
        public IActionResult DeleteCarroDaLista()
        {
            CarrosDaClasse.RemoveAt(CarrosDaClasse.Count - 1);
            return Ok(CarrosDaClasse);
        }
    }
}