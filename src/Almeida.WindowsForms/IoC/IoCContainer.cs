using Almeida.Application.AutoMapper;
using Almeida.CrossCutting;
using Almeida.Domain.ValueObjects;
using Almeida.WindowsForms.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almeida.WindowsForms.IoC
{
    public class IoCContainer
    {
        private static IServiceProvider Container;
        public static void Register(IServiceCollection services)
        {

            var connectionStrings = new ConnectionStrings
            {
                AlmeidaConnectionStrings = ConfigurationManager.ConnectionStrings["AlmeidaConnectionStrings"].ConnectionString
            };

            services.AddSingleton(connectionStrings);
            //services.AddSingleton(new AlmeidaConfiguration());
            services.AddSingleton(AutoMapperConfiguration.RegisterMappings().CreateMapper());
            NativeInjectorBootStrapper.RegisterServices(services);


            Container = services.BuildServiceProvider();

        }
        public static T GetService<T>()
        {
            return (T)Container.GetService(typeof(T));
        }


    }
}