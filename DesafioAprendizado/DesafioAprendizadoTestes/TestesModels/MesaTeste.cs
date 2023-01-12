using Entities.Models;

namespace DesafioAprendizadoTestes.TestesModels
{
    public class MesaTeste
    {
        [Fact]
        public void Criar_Nova_Mesa()
        {
            // Arrange
            var time = DateTime.Now;

            var novaMesa = new Mesa
            {
                MesaId = 1,
                MesaDataUltimaAtualizacao = time
            };

            // Act


            // Assert
            Assert.Equal(1, novaMesa.MesaId);
            Assert.False(novaMesa.MesaOcupada);
            Assert.False(novaMesa.MesaDeletada);
            Assert.Equal(time, novaMesa.MesaDataUltimaAtualizacao);
        }
    }
}
