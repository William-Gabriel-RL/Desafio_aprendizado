namespace BusinessLayer.DTO.ProdutoCategoriaDTO
{
    public class AtualizarProdutoCategoriaDTO
    {
        public int ProdutoId { get; set; }
        public int CategoriaId { get; set; }
        public bool ProdutoCategoriaDeletado { get; set; }
    }
}
