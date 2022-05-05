using Xunit;
using Exercicio_Concessionaria.Models;
using System;
namespace Concessionaria.Teste
{
    public class UnitTest1
    {   //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+= Classe "Carro" do Projeto Concessionaria +=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        [Fact]
        public void SeATransmissaoForAutomaticaCalcularValorMaisVintePorCento()
        {   //Arrange
            Carro carro = new Carro("Fiat", "Uno", DateTime.Now, 10000, "Vermelho", 5.000, true, "Alcool");
            //Act            
            var valor = carro.CalcularValor(100.00);
            //Assert
            Assert.Equal(120, valor);
        }

        [Fact]
        public void VeiculoDeveTerUmTipoDeTransmissaoValido()
        {   //Arrange
            Carro carro = new Carro("Fiat", "Uno", DateTime.Now, 10000, "Vermelho", 5.000, true, "Alcool");
            //Act
            carro.SetTransmissaoAutomatica(true);
            //Assert
            Assert.Equal(true, carro.GetTransmissaoAutomatica());
        }

        [Fact]
        public void VeiculoDeverTerUmTipoDeCombustivelCadastrado()
        {   //Arrange
            Carro carro = new Carro("Fiat", "Uno", System.DateTime.Now, 10000, "Vermelho", 5.000, true, "Alcool");
            //Act
            carro.SetCombustivel("Gasolina");
            //Assert
            Assert.Equal("Gasolina", carro.GetCombustivel());
        }

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+= Classe "Cliente" do Projeto Concessionaria +=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        [Fact]
        public void ClienteDeveTerEmailValidoCadastrado()
        {   //Arrange
            Cliente cliente = new Cliente("Pedro", "04658284032", DateTime.Now, "pedropaulo@gmail.com", "51998979495");
            //Act
            cliente.SetEmail("PedroPaulo@gmail.com");
            //Assert
            Assert.Equal("PedroPaulo@gmail.com", cliente.GetEmail());
        }

        [Fact]
        public void ClienteDeveTerTelefoneValidoCadastrado()
        {   //Arrange
            Cliente cliente = new Cliente("Pedro", "04658284032", DateTime.Now, "pedropaulo@gmail.com", "51998979495");
            //Act
            cliente.SetTelefone("51998979495");
            //Assert
            Assert.Equal("51998979495", cliente.GetTelefone());
        }

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+= Classe "Funcionário" do Projeto Concessionaria +=+=+=+=+=+=+=+=+
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        [Fact]
        public void FuncionarioDeveTerCargoValidoCadastrado()
        {   //Arrange
            Funcionario funcionario = new Funcionario("Pedro", "04658284032", DateTime.Now, "Gerente");
            //Act
            funcionario.SetCargo("Gerente");
            //Assert
            Assert.Equal("Gerente", funcionario.GetCargo());
        }

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+ Classe "Moto" do Projeto Concessionaria +=+=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        [Fact]
        public void CalcularValorSeAPartidaForEletrica()
        {   //Arrange
            Moto moto = new Moto("Honda", "CBX250", DateTime.Now, 10000, "Preta", 5.000, 250, "Eletrica");
            //Act
            var valor = moto.CalcularValor(5.000);
            //Assert
            Assert.Equal(1250, valor);
        }

        [Fact]
        public void MotoDeveTerPotenciaDoMotorCadastrada()
        {   //Arrange
            Moto moto = new Moto("Honda", "CBX250", DateTime.Now, 10000, "Preta", 5.000, 250, "Pedal");
            //Act
            moto.SetCilindrada(250);
            //Assert
            Assert.Equal(250, moto.GetCilindrada());
        }

        [Fact]
        public void MotoDeveTerTipoDePartidaCadastrada()
        {   //Arrange
            Moto moto = new Moto("Honda", "CBX250", DateTime.Now, 10000, "Preta", 5.000, 250, "Pedal");
            //Act
            moto.SetPartida("Pedal");
            //Assert
            Assert.Equal("Pedal", moto.GetPartida());
        }

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+ Classe "Pessoa" do Projeto Concessionaria +=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        [Fact]
        public void PessoaDeveTerUmNomeCadastradoValido()
        {   //Arrange
            Pessoa pessoa = new Pessoa("Rafael", "04203562525", DateTime.Now);
            //Act
            pessoa.SetNome("Pedro");
            //Assert
            Assert.Equal("Pedro", pessoa.GetNome());
        }

        [Fact]
        public void PessoaDeveTerUmCPFCadastradoValido()
        {   //Arrange
            Pessoa pessoa = new Pessoa("Rafael", "04203562525", DateTime.Now);
            //Act
            pessoa.SetCpf("04435225823");
            //Assert
            Assert.Equal("04435225823", pessoa.GetCpf());
        }

        [Fact]
        public void PessoaDeveTerUmaDataDeNascimentoCadastradaValida()
        {   //Arrange
            Pessoa pessoa = new Pessoa("Rafael", "04203562525", DateTime.Now);
            //Act
            var data = DateTime.Now;
            pessoa.SetDataNascimento(data);
            //Assert
            Assert.Equal(data, pessoa.GetDataNascimento());
        }

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+= Classe "Veículo" do Projeto Concessionaria +=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+

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

        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+= Classe "Venda" do Projeto Concessionaria +=+=+=+=+=+=+=+=+=+=+=+
        //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+

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
            Assert.Equal(1.000,venda.GetValorFinal());
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
            Assert.Equal(veiculoInserido,veiculoEsperado);
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