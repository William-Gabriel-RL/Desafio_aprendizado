namespace Entities.Models
{
    public class UsuarioTipo
    {
        public int UsuarioTipoId { get; set; }
        public string UsuarioTipoNome { get; set; } = string.Empty;
        public bool UsuarioTipoDeletado { get; set; } = false;
        public DateTime UsuarioTipoDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
