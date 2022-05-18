using Xunit;
using Exercicio_Concessionaria.Models;
using System;
namespace Concessionaria.Teste
{
    public class FuncionarioTeste
    {          

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

        

        

        

        

    }
}