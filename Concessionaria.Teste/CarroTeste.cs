using Xunit;
using Exercicio_Concessionaria.Models;
using System;
using Concessionaria.web.MyExceptions;


namespace Concessionaria.Teste
{
    public class CarroTeste
    {        
        [Fact]
        public void SeATransmissaoForAutomaticaCalcularValorMaisVintePorCento()
        {   //Arrange
            Carro carro = new Carro("Fiat", "Uno", DateTime.Now, 10000, "Vermelho", 5000, true, "Alcool");
            //Act            
            var valor = carro.CalcularValor(100.00);
            //Assert
            Assert.Equal(120, valor);
        }

        [Fact]
        public void VeiculoDeveTerUmTipoDeTransmissaoValido()
        {   //Arrange
            Carro carro = new Carro("Fiat", "Uno", DateTime.Now, 10000, "Vermelho", 5000, true, "Alcool");
            //Act
            carro.SetTransmissaoAutomatica(true);
            //Assert
            Assert.Equal(true, carro.GetTransmissaoAutomatica());
        }

        [Fact]
        public void VeiculoDeverTerUmTipoDeCombustivelCadastrado()
        {   //Arrange
            Carro carro = new Carro("Fiat", "Uno", System.DateTime.Now, 10000, "Vermelho", 6000, true, "Alcool");
            //Act
            carro.SetCombustivel("Gasolina");
            //Assert
            Assert.Equal("Gasolina", carro.GetCombustivel());
        }
        [Fact]
        public void TestandoSeCarroNaoSalvaValorIncorreto()
        {
            //Arrange - Preparando
            var valorIncorreto = 150;
            //Act e Asser
            var exceptionTest = Assert.Throws<ValidarInput>(() => new Carro("Fiat", "Fiorino", DateTime.Parse("01/01/2020"), 0, "Preto", valorIncorreto, true, "flex"));
            Assert.Equal("Valor Inválido!", exceptionTest.Message);
        }
    }
}
