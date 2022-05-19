using Xunit;
using Exercicio_Concessionaria.Models;
using System;

namespace Concessionaria.Teste
{
    public class VeiculoTeste
    {
        

        [Fact]
        public void VeiculoDeveTerUmaMarcaValida()
        {   //Arrange
            Veiculo veiculo = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            //Act
            veiculo.SetMarca("Fiat");
            //Assert
            Assert.Equal("Fiat", veiculo.GetMarca());
        }

        [Fact]
        public void VeiculoDeveTerUmModeloValidoCadastrado()
        {   //Arrange
            Veiculo veiculo = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            //Act
            veiculo.SetModelo("Doblô");
            //Assert
            Assert.Equal("Doblô", veiculo.GetModelo());
        }

        [Fact]
        public void VeiculoDeveTerUmAnoDeFabricacaoCadastradoValido()
        {   //Arrange
            Veiculo veiculo = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            //Act
            veiculo.SetAno(DateTime.Parse("30/01/2020"));
            //Assert
            Assert.Equal(DateTime.Parse("30/01/2020"), veiculo.GetAno());
        }

        [Fact]
        public void VeiculoDeveTerUmaKilometragemValidaCadastrada()
        {   //Arrange
            Veiculo veiculo = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            //Act
            veiculo.SetKilometragem(20000);
            //Assert
            Assert.Equal(20000, veiculo.GetKilometragem());
        }

        [Fact]
        public void VeiculoDeveTerUmaCorValidaCadastrada()
        {   //Arrange
            Veiculo veiculo = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            //Act
            veiculo.SetCor("Vermelho");
            //Assert
            Assert.Equal("Vermelho", veiculo.GetCor());
        }

        [Fact]
        public void VeiculoDeveTerUmValorCadastradoValido()
        {   //Arrange
            Veiculo veiculo = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            //Act
            veiculo.SetValor(60.000);
            //Assert
            Assert.Equal(60.000, veiculo.GetValor());
        }
    }
}
