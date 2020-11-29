using Almeida.Application.ViewModels;
using System.Collections.Generic;

namespace Almeida.Application.Interfaces
{
    public interface IPessoaServices
    {
        IList<PessoaViewModel> GetByAll();
    }
}
