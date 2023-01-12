using Entities.Models;

namespace Repositorys.DTO.ProdutoComandaDTO
{
    public class ExibirProdutoComandaDTO
    {
        public int ProdutoComandaId { get; set; }
        public int ProdutoComandaQuantidadeProdutos { get; set; }
        public decimal ProdutoComandaPreco { get; set; } = 0.0m;
        public string ProdutoComandaObservacao { get; set; }
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public Guid ComandaId { get; set; }
        public string Mesa { get; set; }
        public virtual IEnumerable<ExibirProdutoComandaSituacaoStatus> Situacoes { get; set; }
        public DateTime ProdutoComandaDataUltimaAtualizacao { get; set; }
    }
}
