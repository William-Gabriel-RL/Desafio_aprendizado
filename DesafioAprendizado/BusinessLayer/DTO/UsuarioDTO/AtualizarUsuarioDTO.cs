namespace BusinessLayer.DTO.UsuarioDTO
{
    public class AtualizarUsuarioDTO
    {
        public string UsuarioMatricula { get; set; } = string.Empty;
        public string UsuarioNome { get; set; } = string.Empty;
        public string UsuarioSenha { get; set; } = string.Empty;
        public int? UsuarioTipoId { get; set; }
        public bool UsuarioDeletado { get; set; }
    }
}
