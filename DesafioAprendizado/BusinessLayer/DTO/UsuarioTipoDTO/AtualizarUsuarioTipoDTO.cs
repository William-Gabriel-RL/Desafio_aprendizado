namespace BusinessLayer.DTO.UsuarioTipoDTO
{
    public class AtualizarUsuarioTipoDTO
    {
        public int UsuarioTipoId { get; set; }
        public string UsuarioTipoNome { get; set; } = string.Empty;
        public bool UsuarioTipoDeletado { get; set; }
    }
}
