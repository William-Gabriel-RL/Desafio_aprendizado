namespace Repositorys.DTO.ProdutoComandaDTO
{
    public class ExibirProdutoComandaSituacaoStatus
    {
        public int ProdutoComandaSituacaoId { get; set; }
        public DateTime ProdutoComandaSituacaoDataHora { get; set; }
        public string? ProdutoComandaSituacaoMotivo { get; set; }
        public string UsuarioMatricula { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioTipo { get; set; }
        public int StatusSituacaoId { get; set; }
        public string StatusSituacaoNome { get; set; }
        public bool ProdutoComandaSituacaoDeletado { get; set; }
        public DateTime ProdutoComandaSituacaoDataUltimaAtualizacao { get; set; }
    }
}
