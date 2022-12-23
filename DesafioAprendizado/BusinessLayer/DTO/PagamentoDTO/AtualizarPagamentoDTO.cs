namespace BusinessLayer.DTO.PagamentoDTO
{
    public class AtualizarPagamentoDTO
    {
        public int PagamentoId { get; set; }
        public decimal Valor { get; set; } = 0.0m;
        public int FormaPagamentoId { get; set; }
        public string ComandaId { get; set; } = string.Empty;
        public string UsuarioMatricula { get; set; } = string.Empty;
        public bool PagamentoDeletado { get; set; } = false;
    }
}
