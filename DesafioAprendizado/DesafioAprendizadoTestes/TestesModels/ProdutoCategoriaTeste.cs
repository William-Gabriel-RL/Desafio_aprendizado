using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class ProdutoCategoriaTeste
    {
        [Fact]
        public void Criar_Novo_ProdutoCategoria()
        {
            // Arrange
            var time = DateTime.Now;
            var produtoCategoria = new ProdutoCategoria
            {
                ProdutoId = 1,
                Produto = new Produto
                {
                    ProdutoId = 1,
                    ProdutoNome = "Hamburguer"
                },
                CategoriaId = 1,
                Categoria = new Categoria
                {
                    CategoriaId = 1,
                    CategoriaNome = "Lanche"
                },
                ProdutoCategoriaDataUltimaAtualizacao = time
            };

            // Act

            // Assert
            Assert.Equal(1, produtoCategoria.ProdutoId);
            Assert.Equal("Hamburguer", produtoCategoria.Produto.ProdutoNome);
            Assert.Equal(1, produtoCategoria.CategoriaId);
            Assert.Equal("Lanche", produtoCategoria.Categoria.CategoriaNome);
            Assert.False(produtoCategoria.ProdutoCategoriaDeletado);
            Assert.Equal(time, produtoCategoria.ProdutoCategoriaDataUltimaAtualizacao);
        }
    }
}
