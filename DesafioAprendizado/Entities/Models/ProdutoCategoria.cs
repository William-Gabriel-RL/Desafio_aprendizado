﻿namespace Entities.Models
{
    public class ProdutoCategoria
    {
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set;}
        public bool ProdutoCategoriaDeletado { get; set; } = false;
        public DateTime ProdutoCategoriaDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
