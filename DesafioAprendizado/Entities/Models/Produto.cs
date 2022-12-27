namespace Entities.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; } = string.Empty;
        public string ProdutoDescricao { get; set; } = string.Empty;
        public decimal Preco { get; set; } = 0.0m;
        public bool ProdutoDeletado { get; set; } = false;
        public DateTime ProdutoDataUltimaAtualizacao { get; set; } = DateTime.Now;
        public string? ProdutoFotoId { get; set; } = string.Empty;
        public string UsuarioId { get; set; } = string.Empty;
        public virtual ICollection<ProdutoCategoria> Categorias { get; set; }
    }
}
