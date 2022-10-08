using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data.Entity.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication4
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
            //var connection = "Server=DESKTOP-3VGFU1M;Database:database;Trusted_Connection=True;MultipleActiveResultSets=true";
            //services.AddDbContext<CCSDataAccsess,> (option => option.UseSqlServer(connection));

            services.AddDbContext<CCSDataAccsess>(options =>
                         options.UseSqlServer("Data Source=DESKTOP-3VGFU1M;Initial Catalog=ExampleEFcore2;Trusted_Connection=True;MultipleActiveResultSets=true"));

            services.AddAuthorization();
            services.AddControllers();
            services.AddControllersWithViews();
            services.AddRazorPages()
                    .AddRazorRuntimeCompilation();
            //services.<CCSDataAccsess>(option => option.UseSqlServer(Connection));
            // services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,CCSDataAccsess cCSData)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                DataBaseSeed.Seed(cCSData);
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
