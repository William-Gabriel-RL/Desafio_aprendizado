namespace BusinessLayer.DTO.StatusSituacaoDTO
{
    public class AtualizarStatusSituacaoDTO
    {
        public int StatusSituacaoId { get; set; }
        public string StatusSituacaoNome { get; set; } = string.Empty;
        public bool StatusSituacaoDeletado { get; set; } = false;
    }
}
