using System.Text.Json.Serialization;

namespace Repositorys.DTO.UsuarioDTO
{
    public class ExibirUsuarioDTO
    {
        public string UsuarioMatricula { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioTipo { get; set; }
        public DateTime UsuarioDataUltimaAtualizacao { get; set; }
    }
}
