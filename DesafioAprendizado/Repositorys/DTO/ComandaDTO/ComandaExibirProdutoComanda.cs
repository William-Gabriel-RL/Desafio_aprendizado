namespace Repositorys.DTO.ComandaDTO
{
    public class ComandaExibirProdutoComanda
    {
        public int ProdutoComandaQuantidadeProdutos { get; set; }
        public string ProdutoComandaNome { get; set; }
        public decimal ProdutoComandaPreco { get; set; }
        public string ProdutoComandaObservacao { get; set; } = string.Empty;
    }
}
