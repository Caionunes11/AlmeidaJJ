using Almeida.Domain.Entities;
using System.Collections.Generic;

namespace Almeida.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        IList<Pessoa> GetByAll();
    }
}
