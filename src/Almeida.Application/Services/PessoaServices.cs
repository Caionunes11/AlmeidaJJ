using Almeida.Application.Interfaces;
using Almeida.Application.ViewModels;
using Almeida.Domain.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace Almeida.Application.Services
{
    public class PessoaServices : IPessoaServices
    {

        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;

        public PessoaServices(IPessoaRepository pessoaRepository, IMapper mapper)
        {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;
        }

        public IList<PessoaViewModel> GetByAll()
        {
            return _mapper.Map<IList<PessoaViewModel>>(_pessoaRepository.GetByAll());
        }
        //public IList<PessoaViewModel> GetByAll()
        //{
        //    return new List<PessoaViewModel>()
        //    {
        //        new PessoaViewModel()
        //        {
        //            Nome = "Caio"
        //        }
        //    };
        //}
    }
}
