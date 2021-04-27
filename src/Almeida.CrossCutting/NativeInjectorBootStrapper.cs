using Almeida.Application.Interfaces;
using Almeida.Application.Services;
using Almeida.Domain.Interfaces;
using Almeida.Infrastructure.Context;
using Almeida.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Almeida.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IPessoaServices, PessoaServices>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IAtividadeServices, AtividadeServices>();
            services.AddScoped<IAtividadeRepository, AtividadeRepository>();

            services.AddScoped<AlmeidaContext>();
        }
    }
}
