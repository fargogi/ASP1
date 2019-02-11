using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyWebStore.Infrastructure.Implementations;
using MyWebStore.Infrastructure.Interfaces;

namespace MyWebStore
{
    public class Startup
    {
        /// <summary>
        /// Свойство для доступа к конфигурации
        /// </summary>
        public IConfiguration Configuration { get; }


        /// <summary>
        /// Конструктор, принимающий интерфейс IConfiguration
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Добавление сервисов для MVC
            services.AddMvc();

            services.AddSingleton<IEmployeesData, InMemoryEmployeesData > ();
            services.AddSingleton<IProductData, InMemoryProductData>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Поддержка статических файлов
            app.UseStaticFiles();

            //Обработка запросов в mvc-формате 
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                                name: "default", 
                                template: "{controller=Home}/{action=Index}/{id?}");


            });
        }
    }
}
