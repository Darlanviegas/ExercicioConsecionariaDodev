namespace Exercicio_Concessionaria.Models
{
    public class Carro : Veiculo
    {
        private bool TransmissaoAutomatica { get; set; }
        private string Combustivel { get; set; }

        public override double CalcularValor(double valor)
        {
            return valor;
        }

        //Get e Set TransmisãoAutomática
        public bool GetTransmissaoAutomatica(bool transmissaoautomatica)
        {
            return transmissaoautomatica;
        }
        public void SetTransmissaoAutomatica(bool transmissaoautomatica)
        {
            TransmissaoAutomatica = transmissaoautomatica;
        }

        //Get e Set Combustível
        public string GetCombustivel(string combustivel)
        {
            return combustivel;
        }
        public void SetCombustivel(string combustivel)
        {
            Combustivel = combustivel;
        }

    }
}