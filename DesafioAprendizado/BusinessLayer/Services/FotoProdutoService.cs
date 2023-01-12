using BusinessLayer.Interfaces;
using Repositorys.Context;
using Repositorys.Interfaces;
using Repositorys.Repos;

namespace BusinessLayer.Services
{
    public class FotoProdutoService : IFotoProdutoService
    {
        private readonly IFotoProdutoRepo _repo;
        public FotoProdutoService()
        {
            _repo = new FotoProdutoRepo(new DesafioAprendizadoContext());
        }

        public string AtualizarFotoProduto(string? fotoProdutoId, string path)
        {
            return _repo.AtualizarFotoProduto(fotoProdutoId, path);
        }

        public void DeletarFotoProduto(string fotoProdutoId)
        {
            _repo.DeletarFotoProduto(fotoProdutoId);
        }

        public byte[] ObterFotosProdutos(string? fotoProdutoId)
        {
            return _repo.ObterFotosProdutos(fotoProdutoId);
        }

        public string SalvarFotoProduto(string path)
        {
            return _repo.SalvarFotoProduto(path);
        }
    }
}
