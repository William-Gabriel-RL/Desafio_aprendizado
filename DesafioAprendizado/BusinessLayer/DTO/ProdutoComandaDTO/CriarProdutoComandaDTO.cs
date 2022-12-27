namespace BusinessLayer.DTO.ProdutoComandaDTO
{
    public class CriarProdutoComandaDTO
    {
        public int ProdutoComandaQuantidadeProdutos { get; set; }
        public string ProdutoComandaObservacao { get; set; } = string.Empty;
        public int ProdutoId { get; set; }
        public string ComandaId { get; set; } = string.Empty;
    }
}
