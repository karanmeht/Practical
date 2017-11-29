using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NewsPaperSubscribe.Models;
using Microsoft.EntityFrameworkCore;
using NewsPaperSubscribe.Repository.NewsPaperSubscribe;

namespace NewsPaperSubscribe
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<NewsPaperDbContext>(Options => Options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewsPaper;Integrated Security=True;"));
            services.AddDbContext<NewsPaperDbContext>();

            services.AddScoped<INewsPaperSubscribeRepository, NewsPaperSubscribeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(); 

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(route=>
            {
            route.MapRoute(
                name: "Default",
                template:"{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}