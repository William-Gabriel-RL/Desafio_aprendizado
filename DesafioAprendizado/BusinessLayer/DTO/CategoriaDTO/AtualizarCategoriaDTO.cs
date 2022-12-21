namespace BusinessLayer.DTO.CategoriaDTO
{
    public class AtualizarCategoriaDTO
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; } = string.Empty;
        public bool CategoriaDeletado { get; set; } = false;
    }
}
