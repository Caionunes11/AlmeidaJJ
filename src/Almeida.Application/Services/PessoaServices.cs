using Almeida.Application.Interfaces;
using Almeida.Application.ViewModels;
using Almeida.Domain.Entities;
using Almeida.Domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace Almeida.Application.Services
{
    public class PessoaServices : IPessoaServices
    {

        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;

        public PessoaServices(IPessoaRepository pessoaRepository, IMapper mapper)
        {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;
        }

        public IList<PessoaViewModel> GetByAll()
        {
            return _mapper.Map<IList<PessoaViewModel>>(_pessoaRepository.GetByAll());
        }

        public PessoaViewModel GetById(int pessoaId)
        {
            return _mapper.Map<PessoaViewModel>(_pessoaRepository.GetById(pessoaId));
        }

        public int SalvarPessoa(PessoaViewModel pessoaViewModel)
        {
            var entidade = _mapper.Map<Pessoa>(pessoaViewModel);
            entidade.DataAlteracao = null;
            entidade.DataCriacao = DateTime.Now;
            return _pessoaRepository.SalvarPessoa(entidade);
        }

        public void AtualizarPessoa(PessoaViewModel pessoaViewModel)
        {
            var pessoa = GetById(pessoaViewModel.Id);
            
            if (pessoa == null)
            {
                SalvarPessoa(pessoaViewModel);
            }
            else
            {
                _pessoaRepository.AtualizarPessoa(new Pessoa()
                {
                    Id = pessoaViewModel.Id,
                    Nome = pessoaViewModel.Nome,
                    Telefone = pessoaViewModel.Telefone,
                    Documento = pessoaViewModel.Documento,
                    Email = pessoaViewModel.Email,
                    DataNascimento = pessoaViewModel.DataNascimento,
                    Sexo = pessoaViewModel.Sexo,
                    Endereco = pessoaViewModel.Endereco,
                    DataCriacao = pessoa.DataCriacao,
                    DataAlteracao = DateTime.Now,
                    Ativo = pessoaViewModel.Ativo,
                    Peso = pessoaViewModel.Peso,
                    Altura = pessoaViewModel.Altura    
                }); 
            }
        }

        public void InativarPessoa(int pessoaId)
        {
            _pessoaRepository.InativarPessoa(pessoaId);
        }
    }
}
