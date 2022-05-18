using System;
using Concessionaria.web.MyExceptions;
namespace Exercicio_Concessionaria.Models
{
    public class Moto : Veiculo
    {
        private int Cilindrada { get; set; }
        private string Partida { get; set; }

        public Moto(string marca, string modelo, DateTime ano, int kilometragem, string cor, double valor, int cilindrada, string partida) : base(marca, modelo, ano, kilometragem, cor, valor)
        {
            SetCilindrada(cilindrada);
            SetPartida(partida);
            SetValor(CalcularValor(valor));
        }

        public override double CalcularValor(double valor)
        {
            if (Partida == "Eletrica")
            {
                valor = (Cilindrada * 50) * 0.1;
                return valor;
            }
            else
            {
                valor = (Cilindrada * 50);
                return valor;
            }
        }

        //Get e Set Cilindrada
        public int GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }

        //Get e Set Partida
        public string GetPartida()
        {
            return Partida;
        }
        public void SetPartida(string partida)
        {
            Partida = partida;
        }
        public override bool ValidarValor(double valor)

        {

            if (valor >= 2000)

            {

                return true;

            }

            throw new ValidarInput("valor inválido!");

        }
    }
}