﻿using BusinessLayer.DTO.MesaDTO;
using BusinessLayer.Interfaces;
using Entities.Models;
using Repositorys.Context;
using Repositorys.DTO.MesaDTO;
using Repositorys.Interfaces;
using Repositorys.Repos;

namespace BusinessLayer.Services
{
    public class MesaService : IMesaService
    {
        private readonly IMesaRepo _mesaRepo;
        public MesaService()
        {
            _mesaRepo = new MesaRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarMesa(AtualizarMesaDTO atualizarMesaDTO)
        {
            Mesa mesa = new()
            {
                MesaId = atualizarMesaDTO.MesaId,
                MesaNome = atualizarMesaDTO.MesaNome,
                MesaOcupada = atualizarMesaDTO.MesaOcupada,
                MesaDeletada = atualizarMesaDTO.MesaDeletada,
                MesaDataUltimaAtualizacao = DateTime.Now
            };
            _mesaRepo.AtualizarMesa(mesa);
        }

        public void CriarMesa(CriarMesaDTO criarMesaDTO)
        {
            Mesa mesa = new Mesa
            {
                MesaNome = criarMesaDTO.MesaNome
            };
            _mesaRepo.CriarMesa(mesa);
        }

        public void DeletarMesa(int mesaId)
        {
            _mesaRepo.DeletarMesa(mesaId);
        }

        public async Task<IEnumerable<ExibirMesaDTO>> ObterMesas(int? mesaId)
        {
            return await _mesaRepo.ObterMesas(mesaId);
        }
    }
}
