
using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class FormaPagamentoTeste
    {
        [Fact]
        public void Criar_Nova_FormaPagamento()
        {
            // Arrange
            var time = DateTime.Now;
            var formaPagamento = new FormaPagamento
            {
                FormaPagamentoId = 1,
                FormaPagamentoNome = "Dinheiro",
                FormaPagamentoDataUltimaAtualizacao= time,
            };

            // Act

            // Assert
            Assert.Equal(1, formaPagamento.FormaPagamentoId);
            Assert.Equal("Dinheiro", formaPagamento.FormaPagamentoNome);
            Assert.False(formaPagamento.FormaPagamentoDeletado);
            Assert.Equal(time, formaPagamento.FormaPagamentoDataUltimaAtualizacao);
        }
    }
}
