using Almeida.Application.Interfaces;
using Almeida.Application.Services;
using Almeida.Domain.Interfaces;
using Almeida.Infrastructure.Repository;
using Ninject.Modules;

namespace Almeida.WindowsForms.IoC
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPessoaServices>().To<PessoaServices>();
            Bind<IPessoaRepository>().To<PessoaRepository>();


        }
        public static FormModule Create()
        {
            return new FormModule();
        }
    }
}
