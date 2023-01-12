using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class UsuarioTeste
    {
        [Fact]
        public void Criar_Novo_Usuario()
        {
            // Arrange

            var time = DateTime.Now;
            var usuario = new Usuario 
            {
                UsuarioMatricula = "001teste",
                UsuarioNome = "Usuario Teste",
                UsuarioSenha = "12345",
                UsuarioTipoId = 1,
                Tipo = new UsuarioTipo 
                {
                    UsuarioTipoId = 1,
                    UsuarioTipoNome = "teste",
                    UsuarioTipoDataUltimaAtualizacao = time,
                },
                UsuarioDataUltimaAtualizacao = time
            };

            // Act

            // Assert
            Assert.Equal("001teste", usuario.UsuarioMatricula);
            Assert.Equal("Usuario Teste", usuario.UsuarioNome);
            Assert.Equal("12345", usuario.UsuarioSenha);
            Assert.Equal(1, usuario.UsuarioTipoId);
            Assert.Equal("teste", usuario.Tipo.UsuarioTipoNome);
            Assert.Equal(time, usuario.UsuarioDataUltimaAtualizacao);
        }
    }
}
