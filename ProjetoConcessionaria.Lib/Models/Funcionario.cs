using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria.Lib.Models
{
    public class Funcionario : Pessoa
    {
        private string Cargo { get; set; }

        public Funcionario(string nome, string cpf, DateTime DataNascimento, string cargo) : base(nome, cpf, DataNascimento)
        {
            SetCargo(cargo);
        }

        //Get e Set Cargo
        public string GetCargo()
        {
            return Cargo;
        }
        public string SetCargo(string cargo)
        {
            Cargo = cargo;
            return Cargo;
        }
    }
}
