using Microsoft.AspNetCore.Mvc;
using Concessionaria.web.DTOs;
using Exercicio_Concessionaria.Models;
namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        public static List<MotoDTO> MotosDaClasseDTO { get; set; } = new List<MotoDTO>();

        [HttpGet("Get MotosDaLista")]
        public IActionResult GetMotosDaLista()
        {
            return Ok(MotosDaClasseDTO);
        }

        [HttpPost("Set MotoNaLista")]
        public IActionResult SetMotoNaLista(MotoDTO motoDto)
        {   var moto1 = new Moto(motoDto.Marca,motoDto.Modelo,motoDto.Ano,motoDto.Kilometragem,motoDto.Cor,motoDto.Valor,motoDto.Cilindrada,motoDto.Partida);
            MotosDaClasseDTO.Add(motoDto);
            return Ok(MotosDaClasseDTO);
        }

        [HttpDelete("Delete MotoDaLista")]
        public IActionResult DeleteMotoDaLista()
        {
            MotosDaClasseDTO.RemoveAt(MotosDaClasseDTO.Count - 1);
            return Ok(MotosDaClasseDTO);
        }

    }
}