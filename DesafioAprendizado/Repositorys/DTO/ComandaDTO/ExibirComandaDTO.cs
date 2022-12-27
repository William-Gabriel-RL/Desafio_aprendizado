namespace Repositorys.DTO.ComandaDTO
{
    public class ExibirComandaDTO
    {
        public Guid ComandaId { get; set; }
        public DateTime ComandaHoraAbertura { get; set; }
        public decimal ComandaTotal { get; set; } = 0.0m;
        public bool ComandaFinalizada { get; set; }
        public bool ComandaDeletado { get; set; }
        public DateTime ComandaDataUltimaAtualizacao { get; set; }
        public string AtendenteMatricula { get; set; }
        public string Atendente { get; set; }
        public int MesaId { get; set; }
        public virtual IEnumerable<ComandaExibirProdutoComanda>? ProdutosComanda { get; set; }
        public virtual IEnumerable<ComandaExibirPagamento>? Pagamento { get; set; }
    }
}
