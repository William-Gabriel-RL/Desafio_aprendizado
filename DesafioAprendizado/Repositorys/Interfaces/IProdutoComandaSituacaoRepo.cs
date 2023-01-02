using Entities.Models;
using Repositorys.DTO;

namespace Repositorys.Interfaces
{
    public interface IProdutoComandaSituacaoRepo
    {
        public void CriarProdutoComandaSituacao(ProdutoComandaSituacao produtoComandaSituacao);
        public Task<IEnumerable<ExibirProdutoComandaSituacaoDTO>> ObterProdutosComandaSituacao(int? produtoComandaSituacaoId, string? usuarioMatricula, int? statusSituacaoId, int? ano, int? mes, int? dia);
        public void AtualizarProdutoComandaSituacao(ProdutoComandaSituacao produtoComandaSituacao);
        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId);
        public void Salvar();
    }
}
