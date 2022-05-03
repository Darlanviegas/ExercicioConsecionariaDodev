namespace Exercicio_Concessionaria.Models
{
    public class Moto : Veiculo
    {
        private int Cilindrada { get; set; }
        private string Partida { get; set; }

        public override double CalcularValor(double valor)
        {
            return valor;
        }

        //Get e Set Cilindrada
        public int GetCilindrada(int cilindrada)
        {
            return cilindrada;
        }
        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }

        //Get e Set Partida
        public string GetPartida(string partida)
        {
            return partida;
        }
        public void SetPartida(string partida)
        {
            Partida = partida;
        }
    }
}