﻿using BusinessLayer.DTO.MesaDTO;
using Entities.Models;
using Repositorys.DTO.MesaDTO;

namespace BusinessLayer.Interfaces
{
    public interface IMesaService
    {
        public void CriarMesa(CriarMesaDTO mesa);
        public Task<IEnumerable<ExibirMesaDTO>> ObterMesas(int? mesaId);
        public void AtualizarMesa(AtualizarMesaDTO mesa);
        public void DeletarMesa(int mesaId);
    }
}
