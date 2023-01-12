namespace BusinessLayer.Interfaces
{
    public interface IFotoProdutoService
    {
        public string SalvarFotoProduto(string path);
        public byte[] ObterFotosProdutos(string? fotoProdutoId);
        public string AtualizarFotoProduto(string? fotoProdutoId, string path);
        public void DeletarFotoProduto(string fotoProdutoId);
    }
}
