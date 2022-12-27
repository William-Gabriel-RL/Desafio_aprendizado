using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.ProdutoCategoriaDTO;
using Entities.Models;
using Repositorys.DTO.ProdutoCategoriaDTO;

namespace BusinessLayer.Services
{
    public class ProdutoCategoriaService : IProdutoCategoriaService
    {
        private readonly IProdutoCategoriaRepo _produtoCategoriaRepo;
        public ProdutoCategoriaService()
        {
            _produtoCategoriaRepo = new ProdutoCategoriaRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarProdutoCategoria(AtualizarProdutoCategoriaDTO atualizarProdutoCategoriaDTO)
        {
            ProdutoCategoria produtoCategoria = new()
            {
                ProdutoId = atualizarProdutoCategoriaDTO.ProdutoId,
                CategoriaId = atualizarProdutoCategoriaDTO.CategoriaId,
                ProdutoCategoriaDeletado = atualizarProdutoCategoriaDTO.ProdutoCategoriaDeletado,
                ProdutoCategoriaDataUltimaAtualizacao = DateTime.Now
            };
            _produtoCategoriaRepo.AtualizarProdutoCategoria(produtoCategoria);
        }

        public void CriarProdutoCategoria(CriarProdutoCategoriaDTO criarProdutoCategoriaDTO)
        {
            ProdutoCategoria produtoCategoria = new()
            {
                ProdutoId = criarProdutoCategoriaDTO.ProdutoId,
                CategoriaId = criarProdutoCategoriaDTO.CategoriaId
            };
            _produtoCategoriaRepo.CriarProdutoCategoria(produtoCategoria);
        }

        public void DeletarProdutoCategoria(int produtoCategoriaId)
        {
            _produtoCategoriaRepo.DeletarProdutoCategoria(produtoCategoriaId);
        }

        public ExibirProdutoCategoriaDTO? ObterProdutoCategoriaPorCategoria(int categoriaId)
        {
            return _produtoCategoriaRepo.ObterProdutoCategoriaPorCategoria(categoriaId);
        }

        public async Task<IEnumerable<ExibirProdutoCategoriaDTO>> ObterTodosProdutosCategorias()
        {
            return await _produtoCategoriaRepo.ObterTodosProdutosCategorias();
        }
    }
}
