using Almeida.Domain.Entities;
using Almeida.Domain.Interfaces;
using Almeida.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
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
            var teste = _context.Pessoa.AsNoTracking().ToList();
            return teste;
        }

    }
}
