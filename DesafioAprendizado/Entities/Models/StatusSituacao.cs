namespace Entities.Models
{
    public class StatusSituacao
    {
        public int StatusSituacaoId { get; set; }
        public string StatusSituacaoNome { get; set; } = string.Empty;
        public bool StatusSituacaoDeletado { get; set; } = false;
        public DateTime StatusSituacaoDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
