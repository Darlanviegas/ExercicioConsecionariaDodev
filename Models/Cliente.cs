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
        public string GetEmail(string email)
        {
            return email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }

        //Get e Set Telefone
        public string GetTelefone(string telefone)
        {
            return telefone;
        }
        public void SetTelefone(string telefone)
        {
            Telefone = telefone;
        }



    }
}