using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class ProdutoTeste
    {
        [Fact]
        public void Criar_Novo_Produto()
        {
            // Arrange
            var time = DateTime.Now;
            var produto = new Produto 
            {
                ProdutoId = 1,
                ProdutoNome = "Hamburguer",
                ProdutoDescricao = "Pão, carne, ketchup e mostarda. Serve 1 pessoa",
                Preco = 5,
                ProdutoDataUltimaAtualizacao = time,
                UsuarioId = "001teste"
            };

            // Act

            // Assert
            Assert.Equal(1, produto.ProdutoId);
            Assert.Equal("Hamburguer", produto.ProdutoNome);
            Assert.Equal("Pão, carne, ketchup e mostarda. Serve 1 pessoa", produto.ProdutoDescricao);
            Assert.Equal(5, produto.Preco);
            Assert.False(produto.ProdutoDeletado);
            Assert.Equal(time, produto.ProdutoDataUltimaAtualizacao);
            Assert.Equal("001teste", produto.UsuarioId);
        }
    }
}
