using Almeida.Application.AutoMapper;
using Almeida.Application.Interfaces;
using Almeida.Application.Services;
using Almeida.CrossCutting;
using Almeida.Domain.ValueObjects;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

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
