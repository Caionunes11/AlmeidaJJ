using Almeida.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Application.Interfaces
{
    public interface IAtividadeServices
    {
        int SalvarAtividade(AtividadeViewModel atividadeViewModel);
    }
}
