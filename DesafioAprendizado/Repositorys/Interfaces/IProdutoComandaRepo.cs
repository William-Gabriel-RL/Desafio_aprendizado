using Entities.Models;
using Repositorys.DTO.ProdutoComandaDTO;

namespace Repositorys.Interfaces
{
    public interface IProdutoComandaRepo
    {
        public void CriarProdutoComanda(ProdutoComanda produtoComanda);
        public ExibirProdutoComandaDTO? ObterProdutoComandaPorId(int produtoComandaId);
        public Task<IEnumerable<ExibirProdutoComandaDTO>> ObterTodosProdutosPorComanda();
        public void AtualizarProdutoComanda(ProdutoComanda produtoComanda);
        public void DeletarProdutoComanda(int produtoComandaId);
        public void Salvar();
    }
}
