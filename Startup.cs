using Manager.Manager;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Model.Model;
using Repository.Context;
using Repository.Repository;
using Swashbuckle.AspNetCore.Swagger;
using System.Text;
using ServiceStack;
using Repository.RepositoryInterface;
using Repository.RepositoryImpl;
using Manager.ManagerImpl;
using Manager.ManagerInterface;

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
            var Jwtsettings = new Jwtsetting();
            configuration.Bind(key: nameof(Jwtsetting), Jwtsettings);
            services.AddSingleton(Jwtsettings);
            services.AddTransient<IAccountRep, AccountRep>();
            services.AddTransient<INotes, NotesRep>();
            services.AddTransient<ILabel, LabelRep>();
            services.AddTransient<ICollaborator, CollaboratorRep>();
            services.AddTransient<IAccountManger, AccountManagerImpl>();
            services.AddTransient<INoteManager, NodeManagerImpl>();
            services.AddTransient<ILabelManager, LabelManagerImpl>();
            services.AddTransient<ICollaboratorManager, CollaboratorManager>();
            services.AddDbContext<UserContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
            services.AddAuthentication(configureOptions: x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
               .AddJwtBearer(x =>
               {
                   x.SaveToken = true;
                   x.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuerSigningKey = true,
                       IssuerSigningKey = new SymmetricSecurityKey(key: Encoding.ASCII.GetBytes(Jwtsettings.Secret)),
                       ValidateIssuer = false,
                       ValidateAudience = false,
                       RequireExpirationTime = false,
                       ValidateLifetime = true,
                   };
               });
            services.AddCors(OP => OP.AddPolicy("Polices", builder =>
            {
                   builder.AllowAnyOrigin();
                   builder.AllowAnyHeader();
                   builder.AllowAnyMethod();
            }));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = "Fundoo Nodes API", 
                    Version = "v1"

                });
               // var Security = new Directory<string, IEnumerable<string>>
                //{
                  //  {"Bearer", new string[0] }
                //};
                c.AddSecurityDefinition(name: "Bearer", new ApiKeyScheme
                {
                    Description = "jwt Authorization using the header scheme",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiakey",
                });

            });
          

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
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
