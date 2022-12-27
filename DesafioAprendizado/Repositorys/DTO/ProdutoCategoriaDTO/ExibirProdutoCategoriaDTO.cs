﻿namespace Repositorys.DTO.ProdutoCategoriaDTO
{
    public class ExibirProdutoCategoriaDTO
    {
        public int ProdutoId { get; set; }
        public string Produto { get; set; }
        public int CategoriaId { get; set; }
        public string Categoria { get; set;}
        public bool ProdutoCategoriaDeletado { get; set; } = false;
        public DateTime ProdutoCategoriaDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
