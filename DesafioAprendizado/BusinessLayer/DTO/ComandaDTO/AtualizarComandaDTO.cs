namespace BusinessLayer.DTO.ComandaDTO
{
    public class AtualizarComandaDTO
    {
        public Guid ComandaId { get; set; }
        public DateTime ComandaHoraAbertura { get; set; }
        public bool ComandaFinalizada { get; set; }
        public bool ComandaDeletado { get; set; }
        public string AtendenteMatricula { get; set; }
        public int MesaId { get; set; }
        public int? PagamentoId { get; set; }
    }
}
