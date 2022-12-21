﻿namespace Entities.Models
{
    public class Mesa
    {
        public int MesaId { get; set; }
        public bool MesaOcupada { get; set; } = false;
        public bool MesaDeletada { get; set; } = false;
        public DateTime MesaDataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
