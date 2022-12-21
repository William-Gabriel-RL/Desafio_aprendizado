namespace Entities.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; } = string.Empty;
        public bool CategoriaDeletado { get; set; } = false;
        public DateTime CategoriaDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
