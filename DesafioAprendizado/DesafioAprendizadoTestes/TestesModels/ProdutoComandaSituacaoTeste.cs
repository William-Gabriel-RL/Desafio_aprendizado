using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class ProdutoComandaSituacaoTeste
    {
        [Fact]
        public void Criar_Nova_ProdutoComandaSituacao()
        {
            // Arrange
            var time = DateTime.Now;
            var produtoComandaSituacao = new ProdutoComandaSituacao
            {
                ProdutoComandaSituacaoId = 1,
                ProdutoComandaSituacaoDataHora = time,
                ProdutoComandaSituacaoDataUltimaAtualizacao = time,
                UsuarioMatricula = "001teste",
                Usuario = new Usuario
                {
                    UsuarioMatricula = "001teste",
                    UsuarioNome = "Usuario teste"
                },
                StatusSituacaoId = 1,
                StatusSituacao = new StatusSituacao
                {
                    StatusSituacaoId = 1,
                    StatusSituacaoNome = "Entregue"
                },
                ProdutoComandaId = 1,
                ProdutoComanda = new ProdutoComanda
                {
                    ProdutoComandaId = 1,

                }
            };

            // Act

            // Assert
            Assert.Equal(1, produtoComandaSituacao.ProdutoComandaSituacaoId);
            Assert.Equal(time, produtoComandaSituacao.ProdutoComandaSituacaoDataHora);
            Assert.False(produtoComandaSituacao.ProdutoComandaSituacaoDeletado);
            Assert.Equal(time, produtoComandaSituacao.ProdutoComandaSituacaoDataUltimaAtualizacao);
            Assert.Equal("001teste", produtoComandaSituacao.UsuarioMatricula);
            Assert.Equal("Usuario teste", produtoComandaSituacao.Usuario.UsuarioNome);
            Assert.Equal(1, produtoComandaSituacao.StatusSituacaoId);
            Assert.Equal("Entregue", produtoComandaSituacao.StatusSituacao.StatusSituacaoNome);
            Assert.Equal(1, produtoComandaSituacao.ProdutoComandaId);
            Assert.False(produtoComandaSituacao.ProdutoComanda.ProdutoComandaDeletado);
        }
    }
}
