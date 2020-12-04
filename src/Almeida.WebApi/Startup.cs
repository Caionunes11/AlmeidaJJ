using Almeida.Application.AutoMapper;
using Almeida.CrossCutting;
using Almeida.Domain.ValueObjects;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Almeida.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSingleton(Configuration.GetSection("ConnectionStrings").Get<ConnectionStrings>());
            services.AddSingleton(AutoMapperConfiguration.RegisterMappings().CreateMapper());

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Tabulador - API .NET Core 2.2 - Class Library .NET Standard 2.0",
                        Version = "1.0.0.0",
                        Description = "",
                        Contact = new Contact
                        {
                            Name = "SQSN",
                            Url = ""
                        }
                    });
            });
            RegisterServices(services);

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials());

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "AlmeidaJJ");
                c.RoutePrefix = string.Empty;
            });

            app.UseStaticFiles();
            app.UseMvc();
        }
        private void RegisterServices(IServiceCollection services)
        {
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
