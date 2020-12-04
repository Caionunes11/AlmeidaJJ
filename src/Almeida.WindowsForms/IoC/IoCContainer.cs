using Almeida.Application.AutoMapper;
using Almeida.Application.Interfaces;
using Almeida.Application.Services;
using Almeida.CrossCutting;
using Almeida.Domain.ValueObjects;
using Almeida.WindowsForms.Formularios;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Configuration;

namespace Almeida.WindowsForms.IoC
{
    public class IoCContainer
    {
       
        //private static IServiceProvider Container;
        //public static void Register(IServiceCollection services)
        //{

        //    var connectionStrings = new ConnectionStrings
        //    {
        //        AlmeidaConnectionStrings = ConfigurationManager.ConnectionStrings["AlmeidaConnectionStrings"].ConnectionString
        //    };

        //    services.AddSingleton(connectionStrings);
        //    //services.AddSingleton(new AlmeidaConfiguration());
        //    services.AddSingleton(AutoMapperConfiguration.RegisterMappings().CreateMapper());
            
        //    services.AddScoped<frmConsultaGeralUsuarios>();
        //    services.AddScoped<frmNovoCadastroColaborador>();
        //    services.AddScoped<frmPrincipal>();
        //    NativeInjectorBootStrapper.RegisterServices(services);

        //    Container = services.BuildServiceProvider();

        //}
        


    }
}