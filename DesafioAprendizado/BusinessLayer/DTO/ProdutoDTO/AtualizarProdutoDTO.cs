namespace BusinessLayer.DTO.ProdutoDTO
{
    public class AtualizarProdutoDTO
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public string ProdutoDescricao { get; set; }
        public decimal Preco { get; set; }
        public bool ProdutoDeletado { get; set; }
        public int CategoriaId { get; set; }
        public string? ProdutoFotoId { get; set; }
        public string UsuarioId { get; set; }
    }
}
