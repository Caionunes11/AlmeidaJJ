using Almeida.Domain.Entities;
using System.Collections.Generic;

namespace Almeida.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        void AtualizarPessoa(Pessoa pessoa);
        IList<Pessoa> GetByAll();
        Pessoa GetById(int pessoaId);
        void InativarPessoa(int pessoaId);
        int SalvarPessoa(Pessoa pessoa);
    }
}
