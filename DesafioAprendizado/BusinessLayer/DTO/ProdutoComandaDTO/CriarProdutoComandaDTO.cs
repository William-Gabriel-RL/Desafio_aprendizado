namespace BusinessLayer.DTO.ProdutoComandaDTO
{
    public class CriarProdutoComandaDTO
    {
        public int ProdutoComandaQuantidadeProdutos { get; set; }
        public decimal ProdutoComandaPreco { get; set; } = 0.0m;
        public string ProdutoComandaObservacao { get; set; } = string.Empty;
        public int ProdutoId { get; set; }
        public string ComandaId { get; set; } = string.Empty;
    }
}
