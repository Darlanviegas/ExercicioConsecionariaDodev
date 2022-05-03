namespace Exercicio_Concessionaria.Models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private DateTime DataNascimento { get; set; }

        public Pessoa(string nome, string cpf, DateTime DataNascimento)
        {
            SetNome(nome);
            SetCpf(cpf);
            SetDataNascimento(DataNascimento);
        }

        //Get e Set Nome
        public string GetNome(string nome)
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        //Get e Set CPF
        public string GetCpf(string cpf)
        {
            return cpf;
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }

        //Get e Set Datanascimento
        public DateTime GetDataNascimento(DateTime datanascimento)
        {
            return datanascimento;
        }
        public void SetDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }
    }
}