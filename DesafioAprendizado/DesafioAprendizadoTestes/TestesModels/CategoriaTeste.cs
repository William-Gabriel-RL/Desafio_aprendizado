using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class CategoriaTeste
    {
        [Fact]
        public void Criar_Nova_Categoria()
        {
            // Arrange

            var time = DateTime.Now;

            Categoria categoria = new Categoria
            {
                CategoriaId = 1,
                CategoriaNome = "teste",
                CategoriaDataUltimaAtualizacao = time
            };

            // Act

            // Assert
            Assert.Equal(1, categoria.CategoriaId);
            Assert.Equal("teste", categoria.CategoriaNome);
            Assert.False(categoria.CategoriaDeletado);
            Assert.Equal(time, categoria.CategoriaDataUltimaAtualizacao);
        }
    }
}
