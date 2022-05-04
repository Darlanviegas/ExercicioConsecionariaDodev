using Xunit;
using Exercicio_Concessionaria.Models;
using System;
namespace Concessionaria.Teste
{
    public class UnitTest1
    {   //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //Classe "Carro" do Projeto Concessionaria
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        [Fact]
        public void SeATransmissaoForAutomaticaCalcularValorMaisVintePorCento()
        {   //Arrange
            Carro carro = new Carro("Fiat", "Uno", DateTime.Now, 10000, "Vermelho", 5.000, true, "Alcool");
            //Act
            carro.SetTransmissaoAutomatica(true);
            //Assert
            Assert.Equal(true, carro.GetTransmissaoAutomatica());
        }

        [Fact]
        public void CalcularValorSeATransmissaoNaoForAutomatica()
        {   //Arrange
            Carro carro = new Carro("Fiat", "Uno", System.DateTime.Now, 10000, "Vermelho", 5.000, true, "Alcool");
            //Act
            carro.SetTransmissaoAutomatica(false);
            //Assert
            Assert.Equal(false, carro.GetTransmissaoAutomatica());
        }
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //Classe "Cliente" do Projeto Concessionaria
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        [Fact]
        public void ClienteDeveTerEmailValidoCadastrado()
        {   //Arrange
            Cliente cliente = new Cliente("Pedro", "04658284032",DateTime.Now,"pedropaulo@gmail.com", "51998979495");
            //Act
            cliente.SetEmail("PedroPaulo@gmail.com");
            //Assert
            Assert.Equal("PedroPaulo@gmail.com", cliente.GetEmail());
        }

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //Classe "Funcionário" do Projeto Concessionaria
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //Classe "Moto" do Projeto Concessionaria
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //Classe "Pessoa" do Projeto Concessionaria
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //Classe "Veículo" do Projeto Concessionaria
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //Classe "Venda" do Projeto Concessionaria
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        /*
        [Fact]
        public void CompradorPrecisaRetornarUmValorValido()
        {   //Arrange
            Venda venda = new Venda("João",);
            venda.SetComprador("João");
            //Act

            //Assert
            Assert.Equal(DataNascimento, morador.GetDataNascimento());
        }
        public void CompradorNãoPodeRetornarUmValorInvalidoOuNullo()
        {   //Arrange
            Venda venda = new Venda();
            var venda = venda;
            //Act
            morador.SetDataNascimento(DataNascimento);
            //Assert
            Assert.Equal(DataNascimento, morador.GetDataNascimento());
        }
        */

    }
}