using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.ProdutoDTO;
using Entities.Models;
using Repositorys.DTO.ProdutoDTO;

namespace BusinessLayer.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepo _produtoRepo;
        public ProdutoService()
        {
            _produtoRepo = new ProdutoRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarProduto(AtualizarProdutoDTO atualizarProdutoDTO)
        {
            Produto produto = new()
            {
                ProdutoId = atualizarProdutoDTO.ProdutoId,
                ProdutoNome = atualizarProdutoDTO.ProdutoNome,
                ProdutoDescricao = atualizarProdutoDTO.ProdutoDescricao,
                Preco = atualizarProdutoDTO.Preco,
                ProdutoDeletado = atualizarProdutoDTO.ProdutoDeletado,
                ProdutoFotoId = atualizarProdutoDTO.ProdutoFotoId,
                UsuarioId = atualizarProdutoDTO.UsuarioId,
                ProdutoDataUltimaAtualizacao = DateTime.Now,
            };
            _produtoRepo.AtualizarProduto(produto);
        }

        public void CriarProduto(CriarProdutoDTO criarProdutoDTO, string matricula)
        {
            Produto produto = new()
            {
                ProdutoNome = criarProdutoDTO.ProdutoNome,
                ProdutoDescricao = criarProdutoDTO.ProdutoDescricao,
                Preco = criarProdutoDTO.Preco,
                ProdutoFotoId = criarProdutoDTO.ProdutoFotoId,
                UsuarioId = matricula,
                ProdutoDataUltimaAtualizacao= DateTime.Now,
            };
            _produtoRepo.CriarProduto(produto);
        }

        public void DeletarProduto(int produtoId)
        {
            _produtoRepo.DeletarProduto(produtoId);
        }

        public ExibirProdutoDTO? ObterProdutoPorId(int produtoId)
        {
            return _produtoRepo.ObterProdutoPorId(produtoId);
        }

        public async Task<IEnumerable<ExibirProdutoDTO>> ObterTodosProdutos()
        {
            return await _produtoRepo.ObterTodosProdutos();
        }
    }
}
