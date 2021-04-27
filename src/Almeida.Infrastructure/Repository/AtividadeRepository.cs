using Almeida.Domain.Entities;
using Almeida.Domain.Interfaces;
using Almeida.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Infrastructure.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly AlmeidaContext _context;

        public AtividadeRepository(AlmeidaContext context) 
        {
            _context = context;
        }

        public int SalvarAtividade(Atividade atividade)
        {
            _context.Atividade.Add(atividade);
            _context.SaveChanges();
            return atividade.Id;
        }

    }
}
