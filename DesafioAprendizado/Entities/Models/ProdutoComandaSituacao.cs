namespace Entities.Models
{
    public class ProdutoComandaSituacao
    {
        public int ProdutoComandaSituacaoId { get; set; }
        public DateTime ProdutoComandaSituacaoDataHora { get; set; } = DateTime.Now;
        public string? ProdutoComandaSituacaoMotivo { get; set; }
        public bool ProdutoComandaSituacaoDeletado { get; set; } = false;
        public DateTime ProdutoComandaSituacaoDataUltimaAtualizacao { get; set; } = DateTime.Now;
        public string UsuarioMatricula { get; set; } = string.Empty;
        public Usuario Usuario { get; set; }
        public int StatusSituacaoId { get; set; }
        public StatusSituacao StatusSituacao { get; set; }
        public int ProdutoComandaId { get; set; }
        public ProdutoComanda ProdutoComanda { get; set; }
    }
}
