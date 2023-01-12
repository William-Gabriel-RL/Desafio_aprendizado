using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class StatusSituacaoTeste
    {
        [Fact]
        public void Criar_Novo_StatusSituacao()
        {
            // Arrange
            var time = DateTime.Now;
            var statusSituacao = new StatusSituacao 
            { 
                StatusSituacaoId = 1,
                StatusSituacaoNome = "Entregue",
                StatusSituacaoDataUltimaAtualizacao = time,
            };

            // Act

            // Assert
            Assert.Equal(1, statusSituacao.StatusSituacaoId);
            Assert.Equal("Entregue", statusSituacao.StatusSituacaoNome);
            Assert.False(statusSituacao.StatusSituacaoDeletado);
            Assert.Equal(time, statusSituacao.StatusSituacaoDataUltimaAtualizacao);
        }
    }
}
