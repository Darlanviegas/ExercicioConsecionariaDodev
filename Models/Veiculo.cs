namespace Exercicio_Concessionaria.Models
{
    public class Veiculo
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private DateTime Ano { get; set; }
        private int Kilometragem { get; set; }
        private string Cor { get; set; }
        private double Valor { get; set; }
        public virtual double CalcularValor(double valor)
        {
            return valor;
        }

        //Get e Set Marca
        public string GetMarca(string marca)
        {
            return marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        //Get e Set Modelo
        public string GetModelo(string modelo)
        {
            return modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        //Get e Set Ano
        public DateTime GetAno(DateTime ano)
        {
            return ano;
        }
        public void SetAno(DateTime ano)
        {
            Ano = ano;
        }

        //Get e Set Kilometragem
        public int GetKilometragem(int kilometragem)
        {
            return kilometragem;
        }
        public void SetKilometragem(int kilometragem)
        {
            Kilometragem = kilometragem;
        }

        //Get e Set Cor
        public string GetCor(string cor)
        {
            return cor;
        }
        public void SetCor(string cor)
        {
            Cor = cor;
        }

        //Get e Set Valor
        public double GetValor(double valor)
        {
            return valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }

    }

}