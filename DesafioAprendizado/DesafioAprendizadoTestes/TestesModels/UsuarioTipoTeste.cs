using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class UsuarioTipoTeste
    {
        [Fact]
        public void Criar_Novo_UsuarioTipo()
        {
            // Arrange
            var time = DateTime.Now;
            var usuarioTipo = new UsuarioTipo
            {
                UsuarioTipoId = 1,
                UsuarioTipoNome = "Administrador",
                UsuarioTipoDataUltimaAtualizacao= time,
            };

            // Act


            // Assert
            Assert.Equal(1, usuarioTipo.UsuarioTipoId);
            Assert.False(usuarioTipo.UsuarioTipoDeletado);
            Assert.Equal("Administrador", usuarioTipo.UsuarioTipoNome);
            Assert.Equal(time, usuarioTipo.UsuarioTipoDataUltimaAtualizacao);
        }
    }
}
