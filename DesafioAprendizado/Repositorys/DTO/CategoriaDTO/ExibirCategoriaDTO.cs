namespace Repositorys.DTO.CategoriaDTO
{
    public class ExibirCategoriaDTO
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; } = string.Empty;
        public DateTime CategoriaDataUltimaAtualizacao { get; set; }
    }
}
