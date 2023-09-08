//Задание
//Добавьте в приложение SampleApp на главное представление ссылку, которая позволит скачать файл data.txt при переходе.
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default2",
                    template: "{controller}/{action}/{categoryName?}",
                     defaults: new { action = "DetailsByCategory", }
                     );

                routes.MapRoute(
                   name: "Default",
                   template: "{controller}/{action}/{id?}",
                   defaults: new {action = "details"},
                   constraints: new { id = new IntRouteConstraint() }
                   );
                //routes.MapRoute(
                //    name: "Default",
                //    template: "{controller=home}/{action=index}"
                //    );
            });

        }
    }
}
