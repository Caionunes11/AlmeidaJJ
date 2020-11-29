using Almeida.Application.ViewModels;
using Almeida.Domain.Entities;
using AutoMapper;

namespace Almeida.Application.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Atividade, AtividadeViewModel>();
            CreateMap<Pagamento, PagamentoViewModel>();
            CreateMap<PessoaAtividade, PessoaAtividadeViewModel>();
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<Presenca, PresencaViewModel>();
            CreateMap<StatusPagamento, StatusPagamentoViewModel>();
            CreateMap<TipoPagamento, TipoPagamentoViewModel>();
        }
    }
}
