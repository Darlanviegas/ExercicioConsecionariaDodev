namespace Exercicio_Concessionaria.Models
{
    public class Venda
    {
        private Cliente Comprador { get; set; }
        private Funcionario Vendedor { get; set; }
        private Veiculo Veiculo { get; set; }
        private string FormaPagamento { get; set; }
        private double ValorFinal { get; set; }

        public double AplicarDesconto(double desconto)
        {
            return desconto;
        }

        //Get e Set Comprador
        public Cliente GetComprador(Cliente comprador)
        {
            return comprador;
        }
        public void SetComprador(Cliente comprador)
        {
            Comprador = comprador;
        }

        //Get e Set Vendedor
        public Funcionario GetVendedor(Funcionario vendedor)
        {
            return vendedor;
        }
        public void SetVendedor(Funcionario vendedor)
        {
            Vendedor = vendedor;
        }

        //Get e Set Veiculo
        public Veiculo GetVeiculo(Veiculo Veiculo)
        {
            return Veiculo;
        }
        public void SetVeiculo(Veiculo Veiculo)
        {
            Veiculo = Veiculo;
        }

        //Get e Set FormaPagamento
        public string GetFormaPagamento(string formapagamento)
        {
            return formapagamento;
        }
        public void SetFormaPagamento(string formapagamento)
        {
            FormaPagamento = formapagamento;
        }

        //Get e Set ValorFinal
        public double GetValorFinal(double valorfinal)
        {
            return valorfinal;
        }
        public void SetValorFinal(double valorfinal)
        {
            ValorFinal = valorfinal;
        }
    }
}