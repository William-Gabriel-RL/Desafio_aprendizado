using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class ComandaTeste
    {
        [Fact]
        public void Criar_Nova_Comanda()
        {
            // Arrange
            var time = DateTime.Now;
            var id = Guid.NewGuid();

            var comanda = new Comanda 
            {
                ComandaId = id,
                ComandaHoraAbertura = time,
                ComandaTotal = 12.65M,
                ComandaDataUltimaAtualizacao = time,
                AtendenteMatricula = "001teste",
                Atendente = new Usuario
                {
                    UsuarioMatricula = "001teste",
                    UsuarioNome = "Usuario teste"
                },
                MesaId = 1,
                Mesa = new Mesa
                {
                    MesaId = 1,
                }
            };

            // Act

            // Assert
            Assert.Equal(id, comanda.ComandaId);
            Assert.Equal(time, comanda.ComandaHoraAbertura);
            Assert.Equal(12.65M, comanda.ComandaTotal);
            Assert.False(comanda.ComandaDeletado);
            Assert.False(comanda.ComandaFinalizada);
            Assert.Equal(time, comanda.ComandaDataUltimaAtualizacao);
            Assert.Equal("001teste", comanda.AtendenteMatricula);
            Assert.Equal("Usuario teste", comanda.Atendente.UsuarioNome);
            Assert.Equal(1, comanda.MesaId);
            Assert.False(comanda.Mesa.MesaDeletada);
            Assert.False(comanda.Mesa.MesaOcupada);
        }
    }
}
