using Xunit;
using Exercicio_Concessionaria.Models;
using System;

namespace Concessionaria.Teste
{
    public class VendaTeste
    {
        

        [Fact]
        public void AplicarDescontoDeCincoPorCentoSobreOValorFinalSeOCargoForGerente()
        {   //Arrange            
            var clienteA = new Cliente("Pedro", "04658284032", DateTime.Now, "pedropaulo@gmail.com", "51998979495");
            var funcionarioA = new Funcionario("Pedro", "04658284032", DateTime.Now, "Gerente");
            var veiculoA = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 20.000);
            Venda venda = new Venda(clienteA, funcionarioA, veiculoA, "Cartao de Credito", 10.000);

            //Act
            var valorfinal = venda.AplicarDesconto();
            //Assert
            Assert.Equal(1.000, venda.GetValorFinal());
        }

        [Fact]
        public void VendaDeveTerUmCompradorCadastradoValido()
        {   //Arrange
            var clienteA = new Cliente("Pedro", "04658284032", DateTime.Now, "pedropaulo@gmail.com", "51998979495");
            var funcionarioA = new Funcionario("Pedro", "04658284032", DateTime.Now, "Gerente");
            var veiculoA = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            Venda venda = new Venda(clienteA, funcionarioA, veiculoA, "Cartao de Credito", 20.000);
            //Act
            venda.SetComprador(clienteA);
            //Assert
            Assert.Equal(clienteA, venda.GetComprador());
        }

        [Fact]
        public void VendaDeveTerUmVendedorCadastradoValido()
        {   //Arrange
            var clienteA = new Cliente("Pedro", "04658284032", DateTime.Now, "pedropaulo@gmail.com", "51998979495");
            var funcionarioA = new Funcionario("Pedro", "04658284032", DateTime.Now, "Gerente");
            var veiculoA = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            Venda venda = new Venda(clienteA, funcionarioA, veiculoA, "Cartao de Credito", 20.000);
            //Act
            venda.SetVendedor(funcionarioA);
            //Assert
            Assert.Equal(funcionarioA, venda.GetVendedor());
        }

        [Fact]
        public void VendaDeveTerUmVeiculoCadastradoValido()
        {   //Arrange
            var clienteA = new Cliente("Pedro", "04658284032", DateTime.Now, "pedropaulo@gmail.com", "51998979495");
            var funcionarioA = new Funcionario("Pedro", "04658284032", DateTime.Now, "Gerente");
            var veiculoInserido = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            Venda venda = new Venda(clienteA, funcionarioA, veiculoInserido, "Cartao de Credito", 20.000);
            //Act            
            var veiculoEsperado = venda.GetVeiculo();
            //Assert
            Assert.Equal(veiculoInserido, veiculoEsperado);
        }

        [Fact]
        public void VendaDeveTerUmaFormaDePagamentoCadastradaValida()
        {   //Arrange
            var clienteA = new Cliente("Pedro", "04658284032", DateTime.Now, "pedropaulo@gmail.com", "51998979495");
            var funcionarioA = new Funcionario("Pedro", "04658284032", DateTime.Now, "Gerente");
            var veiculoA = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            Venda venda = new Venda(clienteA, funcionarioA, veiculoA, "Cartao de Credito", 20.000);
            //Act
            venda.SetFormaPagamento("Cartão De Crédito");
            //Assert
            Assert.Equal("Cartão De Crédito", venda.GetFormaPagamento());
        }

        [Fact]
        public void VendaDeveTerUmValorFinalCadastradoValido()
        {   //Arrange
            var clienteA = new Cliente("Pedro", "04658284032", DateTime.Now, "pedropaulo@gmail.com", "51998979495");
            var funcionarioA = new Funcionario("Pedro", "04658284032", DateTime.Now, "Gerente");
            var veiculoA = new Veiculo("Fiat", "doblô", DateTime.Now, 25000, "Branca", 60.000);
            Venda venda = new Venda(clienteA, funcionarioA, veiculoA, "Cartao de Credito", 20.000);
            //Act
            venda.SetValorFinal(100.00);
            //Assert
            Assert.Equal(100.00, venda.GetValorFinal());
        }
    }
}
