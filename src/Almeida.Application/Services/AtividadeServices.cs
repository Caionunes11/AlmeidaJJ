using Almeida.Application.Interfaces;
using Almeida.Application.ViewModels;
using Almeida.Domain.Entities;
using Almeida.Domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Application.Services
{
    public class AtividadeServices : IAtividadeServices
    {
        private readonly IAtividadeRepository _atividadeRepository;
        private readonly IMapper _mapper;
        public AtividadeServices(IAtividadeRepository atividadeRepository, IMapper mapper)
        {
            _atividadeRepository = atividadeRepository;
            _mapper = mapper;
        }

        public int SalvarAtividade(AtividadeViewModel atividadeViewModel)
        {
            var entidade = _mapper.Map<Atividade>(atividadeViewModel);
            entidade.DataAlteracao = null;
            entidade.DataCriacao = DateTime.Now;
            return _atividadeRepository.SalvarAtividade(entidade);
        }
    }
}
