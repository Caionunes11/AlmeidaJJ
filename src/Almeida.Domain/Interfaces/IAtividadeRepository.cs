using Almeida.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Domain.Interfaces
{
    public interface IAtividadeRepository
    {
        int SalvarAtividade(Atividade atividade);
    }
}
