namespace Entities.Models
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }
        public DateTime PagamentoDataHora { get; set; } = DateTime.Now;
        public decimal Valor { get; set; } = 0.0m;
        public int FormaPagamentoId { get; set; }
        public Mesa FormaPagamento { get; set; }
        public Guid ComandaId { get; set; }
        public Comanda Comanda { get; set; }
        public string UsuarioMatricula { get; set; } = string.Empty;
        public Usuario Usuario { get; set; }
        public bool PagamentoDeletado { get; set; } = false;
        public DateTime PagamentoDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
