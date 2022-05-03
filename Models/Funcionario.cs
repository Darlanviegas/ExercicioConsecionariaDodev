namespace Exercicio_Concessionaria.Models
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
        public void SetCargo(string cargo)
        {
            Cargo = cargo;
        }
    }
}