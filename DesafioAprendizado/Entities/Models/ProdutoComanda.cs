namespace Entities.Models
{
    public class ProdutoComanda
    {
        public int ProdutoComandaId { get; set; }
        public int ProdutoComandaQuantidadeProdutos { get; set; }
        public decimal ProdutoComandaPreco { get; set; } = 0.0m;
        public string ProdutoComandaObservacao { get; set; } = string.Empty;
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public Guid ComandaId { get; set; }
        public virtual Comanda Comanda { get; set; }
        public virtual ICollection<ProdutoComandaSituacao> Situacoes { get; set; }
        public bool ProdutoComandaDeletado { get; set; } = false;
        public DateTime ProdutoComandaDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
