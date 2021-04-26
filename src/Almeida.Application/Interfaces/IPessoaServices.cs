using Almeida.Application.ViewModels;
using System.Collections.Generic;

namespace Almeida.Application.Interfaces
{
    public interface IPessoaServices
    {
        void AtualizarPessoa(PessoaViewModel pessoaViewModel);
        IList<PessoaViewModel> GetByAll();
        PessoaViewModel GetById(int pessoaId);
        void InativarPessoa(int pessoaId);
        int SalvarPessoa(PessoaViewModel pessoaViewModel);
    }
}
