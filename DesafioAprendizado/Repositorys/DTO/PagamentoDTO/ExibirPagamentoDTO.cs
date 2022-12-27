namespace Repositorys.DTO.PagamentoDTO
{
    public class ExibirPagamentoDTO
    {
        public int PagamentoId { get; set; }
        public DateTime PagamentoDataHora { get; set; }
        public decimal Valor { get; set; }
        public int FormaPagamentoId { get; set; }
        public string FormaPagamento { get; set; }
        public Guid ComandaId { get; set; }
        public string UsuarioMatricula { get; set; }
        public string UsuarioNome { get; set; }
        public bool PagamentoDeletado { get; set; }
        public DateTime PagamentoDataUltimaAtualizacao { get; set; }
    }
}
