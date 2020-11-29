using Almeida.Application.ViewModels;
using Almeida.Domain.Entities;
using AutoMapper;

namespace Almeida.Application.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<AtividadeViewModel, Atividade>();
            CreateMap<PagamentoViewModel, Pagamento>();
            CreateMap<PessoaAtividadeViewModel, PessoaAtividade>();
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<PresencaViewModel, Presenca>();
            CreateMap<StatusPagamentoViewModel, StatusPagamento>();
            CreateMap<TipoPagamentoViewModel, TipoPagamento>();
        }

    }
}
