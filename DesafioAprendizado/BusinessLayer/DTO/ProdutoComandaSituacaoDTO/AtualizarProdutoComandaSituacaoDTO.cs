namespace BusinessLayer.DTO.ProdutoComandaSituacaoDTO
{
    public class AtualizarProdutoComandaSituacaoDTO
    {
        public DateTime ProdutoComandaSituacaoDataHora { get; set; }
        public string? ProdutoComandaSituacaoMotivo { get; set; }
        public bool ProdutoComandaSituacaoDeletado { get; set; }
        public string UsuarioMatricula { get; set; }
        public int StatusSituacaoId { get; set; }
        public int ProdutoComandaId { get; set; }
    }
}
