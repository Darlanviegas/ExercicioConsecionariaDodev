using Microsoft.AspNetCore.Mvc;

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