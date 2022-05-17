namespace Concessionaria.web.DTOs
{
    public class VendaDTO
    {
        public ClienteDTO Comprador { get; set; }
        public FuncionarioDTO Vendedor { get; set; }
        public VeiculoDTO Veiculo { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorFinal { get; set; }
    }
}