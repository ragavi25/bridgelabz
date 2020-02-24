using EmployeeManagement.EmployeeViews;
using EmployeeManagement.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement
{
    public class Startup
    {
       
        
        public Startup(IConfiguration configuration)
        {
        }
        public IConfiguration iconfiguration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);
            //services.AddScoped<EmployeeRep>();
            // services.AddDbContext<UserContext>(opt => opt.UseInMemoryDatabase("Employee"));
            services.AddTransient<IUserRepository, EmployeeRep>();
            services.AddTransient<IEmpView, EmployeeView>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            
            app.UseStaticFiles();
            app.UseMvc(route =>
            {
               route.MapRoute(
                    name: "default",
                template: "{controller=User}/{action=Index}/{id?}"
            );
            });
        }
    }
}
