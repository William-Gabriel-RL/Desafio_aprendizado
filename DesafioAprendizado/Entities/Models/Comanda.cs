namespace Entities.Models
{
    public class Comanda
    {
        public Guid ComandaId { get; set; }
        public DateTime ComandaHoraAbertura { get; set; } = DateTime.Now;
        public decimal ComandaTotal { get; set; } = 0.0m;
        public bool ComandaFinalizada { get; set; } = false;
        public bool ComandaDeletado { get; set; } = false;
        public DateTime ComandaDataUltimaAtualizacao { get; set; } = DateTime.Now;
        public string AtendenteMatricula { get; set; } = string.Empty;
        public Usuario Atendente { get; set; }
        public int MesaId { get; set; }
        public Mesa Mesa { get; set; }
        public virtual ICollection<ProdutoComanda> ProdutosComanda { get; set; }
        public virtual ICollection<Pagamento> Pagamento { get; set; }
    }
}
