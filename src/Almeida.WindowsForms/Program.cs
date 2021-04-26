using Almeida.Application.AutoMapper;
using Almeida.CrossCutting;
using Almeida.Domain.ValueObjects;
using Almeida.WindowsForms.Formularios;
using Almeida.WindowsForms.Formularios.Controles;
using Almeida.WindowsForms.IoC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ninject;
using System;
using System.Configuration;

namespace Almeida.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                var connectionStrings = new ConnectionStrings
                {
                    AlmeidaConnectionStrings = ConfigurationManager.ConnectionStrings["AlmeidaConnectionStrings"].ConnectionString
                };

                services.AddSingleton(connectionStrings);
                services.AddSingleton<frmModelo>();
                services.AddSingleton<frmPrincipal>();
                services.AddSingleton<UserControleNovosCadastros>();
                services.AddSingleton<frmCadastroNovoUsuario>();
                services.AddSingleton(AutoMapperConfiguration.RegisterMappings().CreateMapper());
                services.AddLogging(configure => configure.AddConsole());
                NativeInjectorBootStrapper.RegisterServices(services);
            });

            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var formInicial = services.GetRequiredService<frmModelo>();
                    System.Windows.Forms.Application.Run(formInicial);
                }
                catch (Exception ex)
                {
                    NotImplementedException e;
                }
            }
          

        }
    }
}
