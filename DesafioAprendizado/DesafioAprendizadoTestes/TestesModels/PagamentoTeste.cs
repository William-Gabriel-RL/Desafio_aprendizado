using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class PagamentoTeste
    {
        [Fact]
        public void Criar_Novo_Pagamento()
        {
            // Arrange
            var time = DateTime.Now;
            var id = Guid.NewGuid();

            var pagamento = new Pagamento 
            {
                PagamentoId = 1,
                PagamentoDataHora = time,
                Valor = 123.03M,
                FormaPagamentoId = 1,
                FormaPagamento = new FormaPagamento
                {
                    FormaPagamentoId = 1,
                    FormaPagamentoNome = "Dinheiro"
                },
                ComandaId = id,
                Comanda = new Comanda
                {
                    ComandaId = id,
                },
                UsuarioMatricula = "001teste",
                Usuario = new Usuario
                {
                    UsuarioMatricula = "001teste",
                    UsuarioNome = "Usuario teste"
                },
                PagamentoDataUltimaAtualizacao = time             
            };

            // Act

            // Assert
            Assert.Equal(1, pagamento.PagamentoId);
            Assert.Equal(time, pagamento.PagamentoDataHora);
            Assert.Equal(123.03M, pagamento.Valor);
            Assert.Equal(1, pagamento.FormaPagamentoId);
            Assert.Equal("Dinheiro", pagamento.FormaPagamento.FormaPagamentoNome);
            Assert.Equal(id, pagamento.ComandaId);
            Assert.False(pagamento.Comanda.ComandaDeletado);
            Assert.Equal("001teste", pagamento.UsuarioMatricula);
            Assert.Equal("Usuario teste", pagamento.Usuario.UsuarioNome);
            Assert.False(pagamento.PagamentoDeletado);
            Assert.Equal(time, pagamento.PagamentoDataUltimaAtualizacao);
        }
    }
}
