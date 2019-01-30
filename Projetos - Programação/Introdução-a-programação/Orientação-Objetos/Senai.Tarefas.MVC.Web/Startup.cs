using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Senai.Tarefas.MVC.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Adiciona o serviço para utilização da metodologia MVC.
            services.AddMvc();
            
            // Adiciona recursos para utilização de sessões de autenticação de usuário.
            services.AddDistributedMemoryCache();
            
            services.AddSession(
                // Configura a opção para que a sessão encerre em 30 minutos;
                options => options.IdleTimeout = TimeSpan.FromMinutes(30)
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Utiliza sessões
            app.UseSession();
            // Habilita o uso de arquivos como css e js para as páginas
            app.UseStaticFiles();
            // Adiciona uma rota para o "index"
            app.UseMvc (rota => rota.MapRoute (name: "defaults", template: "{controller=Usuario}/{action=Cadastrar}"));
        }
    }
}
