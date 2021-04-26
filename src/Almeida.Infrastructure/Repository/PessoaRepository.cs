using Almeida.Domain.Entities;
using Almeida.Domain.Interfaces;
using Almeida.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Almeida.Infrastructure.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AlmeidaContext _context;

        public PessoaRepository(AlmeidaContext context)
        {
            _context = context;
        }

        public IList<Pessoa> GetByAll()
        {
            var listaPessoa = _context.Pessoa.ToList();
            return listaPessoa;
        }

        public Pessoa GetById(int pessoaId)
        {
            return _context.Pessoa.AsNoTracking().Where(x => x.Id == pessoaId).FirstOrDefault();
        }

        public int SalvarPessoa(Pessoa pessoa)
        {
            _context.Pessoa.Add(pessoa);
            _context.SaveChanges();
            return pessoa.Id;
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            _context.Pessoa.Update(pessoa);
            _context.SaveChanges();
        }

        public void InativarPessoa(int pessoaId)
        {
            var pessoa = GetById(pessoaId);
            pessoa.Ativo = false;
            pessoa.DataAlteracao = DateTime.Now;
            _context.Pessoa.Update(pessoa);
            _context.SaveChanges();
        }


    }
}
