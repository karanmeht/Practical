using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ManagemantSystem.Repository.RepositoryEmployee;
using ManagemantSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ManagemantSystem.Repository.RepositoryAccount;
using Microsoft.Extensions.Configuration;

namespace ManagemantSystem
{
    public class Startup
    {
        //public Startup(IHostingEnvironment hostingEnvironment)
        //{
        //    var builder = new ConfigurationBuilder()
        //         .SetBasePath(hostingEnvironment.ContentRootPath);

        //    //if (hostingEnvironment.IsDevelopment())
        //    //{
        //    //    // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
        //    //    builder.AddUserSecrets<Startup>();
        //    //}
        //    builder.AddEnvironmentVariables();
        //    //Configuration = builder.Build();
        //    builder.Build();
        //}
        public object UrlParameter { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<ManagemantContext>(Options => Options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ManagemantSystem;Integrated Security=True;"));
            services.AddDbContext<ManagemantContext>();

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ManagemantContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            // services.AddTransient<AdvantureWorkContext>();
            //services.AddScoped<IAccountRepository, UserManager>(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseIdentity();
            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //name: "ManagemantSystem",
                //template: "{Employee}/{UpdateEmployee}/{id?}?{}",
                //defaults: new { Controllers = "Employee", action = "Dashboard" }
                //);
                routes.MapRoute(
                    name: "login",
                    template: "login",
                    defaults: new { controller = "Account", action = "Login" });
                routes.MapRoute(
                    name: "account",
                    template: "account",
                    defaults: new { Controllers = "account", action = "RegistrationView" }
                    );
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Employee}/{action=Dashboard}/{id?}");

            });
        }
    }
}
