namespace Repositorys.DTO.ProdutoDTO
{
    public class ExibirProdutoDTO
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public string ProdutoDescricao { get; set; }
        public decimal Preco { get; set; } = 0.0m;
        public bool ProdutoDeletado { get; set; }
        public DateTime ProdutoDataUltimaAtualizacao { get; set; }
        public string? ProdutoFotoId { get; set; }
        public string UsuarioId { get; set; }
        public IEnumerable<ProdutoExibirCategoriaDTO> Categorias { get; set; }
    }
}
