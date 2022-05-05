namespace Exercicio_Concessionaria.Models
{
    public class Venda
    {
        private Cliente Comprador { get; set; }
        private Funcionario Vendedor { get; set; }
        private Veiculo Veiculo { get; set; }
        private string FormaPagamento { get; set; }
        private double ValorFinal { get; set; }

        public Venda(Cliente comprador, Funcionario vendedor, Veiculo veiculo, string formapagamento, double valorfinal)
        {
            SetComprador(comprador);
            SetVendedor(vendedor);
            SetVeiculo(veiculo);
            SetFormaPagamento(formapagamento);
            SetValorFinal(valorfinal);
        }

        //Método para aplicar desconto
        public double AplicarDesconto()
        {
            double valorVeiculo = Veiculo.GetValor();
            string cargoFuncionario = "Gerente";
            if (Vendedor.GetCargo().Contains(cargoFuncionario))
            {
                ValorFinal = valorVeiculo * 0.05;
                
            }
            return valorVeiculo;
        }

        //Get e Set Comprador
        public Cliente GetComprador()
        {
            return Comprador;
        }
        public void SetComprador(Cliente comprador)
        {
            Comprador = comprador;
        }

        //Get e Set Vendedor
        public Funcionario GetVendedor()
        {
            return Vendedor;
        }
        public void SetVendedor(Funcionario vendedor)
        {
            Vendedor = vendedor;
        }

        //Get e Set Veiculo
        public Veiculo GetVeiculo()
        {
            return Veiculo;
        }
        public void SetVeiculo(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }

        //Get e Set FormaPagamento
        public string GetFormaPagamento()
        {
            return FormaPagamento;
        }
        public void SetFormaPagamento(string formapagamento)
        {
            FormaPagamento = formapagamento;
        }

        //Get e Set ValorFinal
        public double GetValorFinal()
        {
            return ValorFinal;
        }
        public void SetValorFinal(double valorfinal)
        {
            ValorFinal = valorfinal;
        }
    }
}