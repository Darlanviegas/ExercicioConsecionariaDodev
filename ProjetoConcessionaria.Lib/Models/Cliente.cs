using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concessionaria.Lib.MyExeptions;

namespace Concessionaria.Lib.Models
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
            ValidarEmail(email);
            Email = email;
        }
        public bool ValidarEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            throw new ValidarInput("email inválido!");
        }

        //Get e Set Telefone
        public string GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone(string telefone)
        {
            if (ValidarTelefone(telefone) == false)
            {
                throw new ValidarInput("Telefone inválido");
            }
            Telefone = telefone;
        }
        public bool ValidarTelefone(string telefone)
        {
            if (telefone.Length > 8 && telefone.Length < 15)
            {
                return true;
            }
            return false;
        }
    }
}
