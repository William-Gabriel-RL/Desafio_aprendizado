namespace BusinessLayer.DTO.ProdutoComandaDTO
{
    public class AtualizarProdutoComandaDTO
    {
        public int ProdutoComandaId { get; set; }
        public int ProdutoComandaQuantidadeProdutos { get; set; }
        public decimal ProdutoComandaPreco { get; set; }
        public string ProdutoComandaObservacao { get; set; }
        public int ProdutoId { get; set; }
        public string ComandaId { get; set; }
        public bool ProdutoComandaDeletado { get; set; }
    }
}
