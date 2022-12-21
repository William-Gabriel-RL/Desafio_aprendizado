namespace Entities.Models
{
    public class FormaPagamento
    {
        public int FormaPagamentoId { get; set; }
        public string FormaPagagamentoNome { get; set; } = string.Empty;
        public bool FormaPagamentoDeletado { get; set; } = false;
        public DateTime FormaPagamentoDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
