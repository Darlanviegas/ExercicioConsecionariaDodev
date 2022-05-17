using Microsoft.AspNetCore.Mvc;

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
        public IActionResult SetClienteNaLista(ClienteDTO cliente)
        {
            ClientesdaClasseDTO.Add(cliente);
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