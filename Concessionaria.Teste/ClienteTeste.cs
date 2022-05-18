using Xunit;
using Exercicio_Concessionaria.Models;
using System;
using Concessionaria.web.MyExceptions;

namespace Concessionaria.Teste
{
    public class ClienteTeste
    {       
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
        [Fact]
        public void TestandoSeClienteNaoSalvaTelefoneIncorreto()
        {
            //Arrange - Preparando
            var telefoneIncorreto = "email&email.com";
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidarInput>(() => new Cliente("Darlan", "02715083025", DateTime.Parse("30/01/1992"), "email@email", telefoneIncorreto));
            Assert.Equal("Telefone inválido", exceptionTest.Message);
        }
        [Fact]
        public void TestandoSeClienteNaoSalvaEmailIncorreto()
        {
            //Arrange - Preparando
            var emailIncorreto = "Email&email.com";
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidarInput>(() => new Cliente("Darlan", "02715083025", DateTime.Parse("30/01/1992"), emailIncorreto, "996107886"));
            Assert.Equal("email inválido!", exceptionTest.Message);
        }
    }
}
