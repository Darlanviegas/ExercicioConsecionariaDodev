using Xunit;
using Exercicio_Concessionaria.Models;
using System;

namespace Concessionaria.Teste
{
    public class PessoaTeste
    {
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
    }
}
