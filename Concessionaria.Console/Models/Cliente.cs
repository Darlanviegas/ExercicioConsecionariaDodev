using System;
using Concessionaria.web.MyExceptions;
namespace Exercicio_Concessionaria.Models
{
    public class Cliente : Pessoa
    {
        private string Email { get; set; }
        private string Telefone { get; set; }

        public Cliente(string nome, string cpf, DateTime dataNascimento, string email, string telefone) : base(nome, cpf, dataNascimento)
        {
            SetEmail(email);
            SetTelefone(telefone);
        }

        //Get e Set Email
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }

        //Get e Set Telefone
        public string GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone(string telefone)
        {            
            if(ValidarTelefone(telefone)== false)
            {
                throw new ValidarInput("Telefone inválido");
            }
            Telefone = telefone;
        }
        public bool ValidarTelefone(string telefone)
        {
            if (telefone.Length <9 && telefone.Length >14)
            {
                return true;
            }
            return false;
        }
    }
}