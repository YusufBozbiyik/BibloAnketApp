using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibloAnketApp
{
    public class Startup
    {
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name:"anasayfa",
                   pattern:"anasayfa",
                   defaults: new {Controller="Home",action="Index"}
                    );

                


                endpoints.MapControllerRoute(
                    name: "Home",
                    pattern:"{Controller=Home}/{action=Index}/{id?}"
                    ) ;
            });
        }
    }
}
