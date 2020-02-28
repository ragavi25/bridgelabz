using Manager.Manager;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Context;
using Repository.Repository;
using Swashbuckle.AspNetCore.Swagger;

namespace Fundoo
{
    public class Startup
    {
        public IConfiguration configuration;
        public Startup(IConfiguration configurations)
        {
            configuration = configurations;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAccountRep, AccountRepImpl>();
            services.AddTransient<IAccountManger, AccountManagerImpl>();
            services.AddDbContext<UserContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
            services.AddCors(OP => OP.AddPolicy("Polices", builder =>
               {
                   builder.AllowAnyOrigin();
                   builder.AllowAnyHeader();
                   builder.AllowAnyMethod();
               }));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "Fundoo Nodes API", 
                    Version = "v1"

                });
            });
           
        }

        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("Polices");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Fundoo Nodes API V1");
                });
            }
            else
            {
                app.UseHsts();
            }
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}
