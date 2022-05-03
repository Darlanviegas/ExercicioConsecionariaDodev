namespace Exercicio_Concessionaria.Models
{
    public class Carro : Veiculo
    {
        private bool TransmissaoAutomatica { get; set; }
        private string Combustivel { get; set; }

        public Carro(string marca, string modelo, DateTime ano, int kilometragem, string cor, double valor,bool transmissaoautomatica, string combustivel) : base(marca,modelo,ano,kilometragem,cor,valor)
        {
            SetTransmissaoAutomatica(transmissaoautomatica);
            SetCombustivel(combustivel);
        }

        public override double CalcularValor(double valor)
        {
            if(TransmissaoAutomatica == true)
            valor = (valor*0.2)+valor;
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