using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using Domain.Handlers;

namespace Site
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v2", new OpenApiInfo
                {
                    Version = "v2",
                    Title = "Titulo API",
                    Description = "Exemplo webapi com swagger",
                    TermsOfService = new Uri("http://www.google.com.br"),
                    Contact = new OpenApiContact
                    {
                        Name = "Jonathan Lemos",
                        Email = string.Empty
                    }
                });

                //c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                //c.SwaggerDoc("v2", new OpenApiInfo { Title = "My API", Version = "v2" });
            });

            services.AddControllers();

            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped(typeof(ICadastroProdutoHandler), typeof(CadastroProdutoHandler));

            //var assembly = AppDomain.CurrentDomain.Load("ICadastroProdutoHandler");
            //services.AddMediatR(assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My api v1");
                //c.SwaggerEndpoint("/swagger/v2/swagger.json", "My api v2");
                c.RoutePrefix = string.Empty;
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
