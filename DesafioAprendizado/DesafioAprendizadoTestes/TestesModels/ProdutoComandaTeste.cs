using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class ProdutoComandaTeste
    {
        [Fact]
        public void Criar_Novo_ProdutoComanda()
        {
            // Arrange
            var time = DateTime.Now;
            var id = Guid.NewGuid();

            var produtoComanda = new ProdutoComanda
            {
                ProdutoComandaId = 1,
                ProdutoComandaQuantidadeProdutos = 2,
                ProdutoComandaPreco = 5,
                ProdutoComandaObservacao = "Sem ketchup em um",
                ProdutoId = 1,
                Produto = new Produto 
                {
                    ProdutoId = 1,
                    ProdutoNome = "Hamburguer"
                },
                ComandaId = id,
                Comanda = new Comanda 
                {
                    ComandaId = id
                },
                ProdutoComandaDataUltimaAtualizacao = time
            };

            // Act

            // Assert
            Assert.Equal(1, produtoComanda.ProdutoComandaId);
            Assert.Equal(2, produtoComanda.ProdutoComandaQuantidadeProdutos);
            Assert.Equal(5, produtoComanda.ProdutoComandaPreco);
            Assert.Equal("Sem ketchup em um", produtoComanda.ProdutoComandaObservacao);
            Assert.Equal(1, produtoComanda.ProdutoId);
            Assert.Equal("Hamburguer", produtoComanda.Produto.ProdutoNome);
            Assert.Equal(id, produtoComanda.ComandaId);
            Assert.False(produtoComanda.Comanda.ComandaFinalizada);
            Assert.False(produtoComanda.ProdutoComandaDeletado);
            Assert.Equal(time, produtoComanda.ProdutoComandaDataUltimaAtualizacao);
        }
    }
}
