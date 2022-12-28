using BusinessLayer.DTO.ProdutoComandaSituacaoDTO;
using Repositorys.DTO;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoComandaSituacaoService
    {
        public void CriarProdutoComandaSituacao(CriarProdutoComandaSituacaoDTO produtoComandaSituacao, string matricula);
        public Task<IEnumerable<ExibirProdutoComandaSituacaoDTO>> ObterProdutosComandaSituacao(int? produtoComandaSituacaoId, string? usuarioMatricula, int? statusSituacaoId);
        public void AtualizarProdutoComandaSituacao(AtualizarProdutoComandaSituacaoDTO produtoComandaSituacao);
        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId);
    }
}
