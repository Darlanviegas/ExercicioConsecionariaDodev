using Xunit;
using Exercicio_Concessionaria.Models;
using System;
using Concessionaria.web.MyExceptions;

namespace Concessionaria.Teste
{
    public class MotoTeste
    {        
        [Fact]
        public void CalcularValorSeAPartidaForEletrica()
        {   //Arrange
            Moto moto = new Moto("Honda", "CBX250", DateTime.Now, 10000, "Preta", 2500, 250, "Pedal");
            //Act
            var valor = moto.CalcularValor(2500);
            //Assert
            Assert.Equal(12500, valor);
        }

        [Fact]
        public void MotoDeveTerPotenciaDoMotorCadastrada()
        {   //Arrange
            Moto moto = new Moto("Honda", "CBX250", DateTime.Now, 10000, "Preta", 5000, 250, "Pedal");
            //Act
            moto.SetCilindrada(250);
            //Assert
            Assert.Equal(250, moto.GetCilindrada());
        }

        [Fact]
        public void MotoDeveTerTipoDePartidaCadastrada()
        {   //Arrange
            Moto moto = new Moto("Honda", "CBX250", DateTime.Now, 10000, "Preta", 5000, 250, "Pedal");
            //Act
            moto.SetPartida("Pedal");
            //Assert
            Assert.Equal("Pedal", moto.GetPartida());
        }
        [Fact]
        public void TestandoSeMotoNaoSalvaValorIncorreto()
        {
            //Arrange 
            var valorIncorreto = 0;
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidarInput>(() => new Moto("Honda", "CBX250", DateTime.Parse("01/01/2020"), 0, "Preto", 10000, valorIncorreto, "Pedal"));
            Assert.Equal("valor inválido!", exceptionTest.Message);
        }
    }
}
