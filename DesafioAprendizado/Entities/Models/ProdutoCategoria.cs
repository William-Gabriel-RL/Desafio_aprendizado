namespace Entities.Models
{
    public class ProdutoCategoria
    {
        public int ProdutoId { get; set; }
        public virtual Produto? Produto { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set;}
        public bool ProdutoCategoriaDeletado { get; set; } = false;
        public DateTime ProdutoCategoriaDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
