namespace BusinessLayer.DTO.PagamentoDTO
{
    public class CriarPagamentoDTO
    {
        public decimal Valor { get; set; } = 0.0m;
        public int FormaPagamentoId { get; set; }
        public string ComandaId { get; set; } = string.Empty;
        public string UsuarioMatricula { get; set; } = string.Empty;
    }
}
