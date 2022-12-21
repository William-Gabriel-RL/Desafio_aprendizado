namespace BusinessLayer.DTO.ProdutoComandaSituacaoDTO
{
    public class CriarProdutoComandaSituacaoDTO
    {
        public string? ProdutoComandaSituacaoMotivo { get; set; }
        public string UsuarioMatricula { get; set; }
        public int StatusSituacaoId { get; set; }
        public int ProdutoComandaId { get; set; }
    }
}
