using Almeida.Application.AutoMapper;
using Almeida.CrossCutting;
using Almeida.Domain.ValueObjects;
using Almeida.WindowsForms.Formularios;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
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
                services.AddSingleton<frmPrincipal>();
                services.AddSingleton<frmConsultaGeralUsuarios>();
                services.AddSingleton<frmNovoCadastroColaborador>();
                services.AddSingleton(AutoMapperConfiguration.RegisterMappings().CreateMapper());
                services.AddLogging(configure => configure.AddConsole());
                NativeInjectorBootStrapper.RegisterServices(services);

                //services.AddScoped<IPessoaServices, PessoaServices>();

            });

            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var form1 = services.GetRequiredService<frmPrincipal>();
                    System.Windows.Forms.Application.Run(form1);
                }
                catch (Exception ex)
                {
                    NotImplementedException e;
                }
            }

            //System.Windows.Forms.Application.EnableVisualStyles();
            //System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            //var services = new ServiceCollection();
            // IoCContainer.Register(services);

            //System.Windows.Forms.Application.Run(new frmPrincipal());
            //System.Windows.Forms.Application.Run(new frmPrincipal());

        }
    }
}
