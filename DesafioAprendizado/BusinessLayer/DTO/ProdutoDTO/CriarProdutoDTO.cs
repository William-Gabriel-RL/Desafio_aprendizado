namespace BusinessLayer.DTO.ProdutoDTO
{
    public class CriarProdutoDTO
    {
        public string ProdutoNome { get; set; } = string.Empty;
        public string ProdutoDescricao { get; set; } = string.Empty;
        public decimal Preco { get; set; } = 0.0m;
        public string? ProdutoFotoId { get; set; } = string.Empty;
    }
}
