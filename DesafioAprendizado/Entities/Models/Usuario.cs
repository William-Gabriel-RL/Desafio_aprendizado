using System.Text.Json.Serialization;

namespace Entities.Models
{
    public class Usuario
    {
        public string UsuarioMatricula { get; set; } = string.Empty;
        public string UsuarioNome { get; set; } = string.Empty;
        [JsonIgnore]
        public string UsuarioSenha { get; set; } = string.Empty;
        public bool UsuarioDeletado { get; set; } = false;
        public int? UsuarioTipoId { get; set; }
        public virtual UsuarioTipo? Tipo { get; set; }
        public DateTime UsuarioDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}