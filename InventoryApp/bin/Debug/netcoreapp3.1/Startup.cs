using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;

namespace InventoryApp
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
            services.AddControllersWithViews();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(1);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddRazorPages().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=ViewLogin}/{id?}");
                    // pattern: "{controller=Admin}/{action=AdminDashboard}/{id?}");
            });
            Models.Classes.ConnectionString.Constr = Configuration.GetSection("ConnectionString").Value.ToString();
            Models.Classes.ConnectionString.Server = Configuration.GetSection("ServerName").Value.ToString();
            Models.Classes.ConnectionString.UserId = Configuration.GetSection("UserID").Value.ToString();
            Models.Classes.ConnectionString.Password = Configuration.GetSection("Password").Value.ToString();

            Models.Classes.ConnectionString.QueryDatabase = Configuration.GetSection("QueryDatabase").Value.ToString();
            Models.Classes.ConnectionString.QueryCategory = Configuration.GetSection("QueryCategory").Value.ToString();
            Models.Classes.ConnectionString.QuerySubCategory = Configuration.GetSection("QuerySubCategory").Value.ToString();
            Models.Classes.ConnectionString.ImageUrl = Configuration.GetSection("ImageUrl").Value.ToString();
            Models.Classes.ConnectionString.DatabaseUrl = Configuration.GetSection("DatabaseUrl").Value.ToString();
            
            Models.Classes.ConnectionString.AppName = Configuration.GetSection("AppName").Value.ToString();
            Models.Classes.ConnectionString.AppInfo = Configuration.GetSection("AppInfo").Value.ToString();
            Models.Classes.ConnectionString.AppVersion = Configuration.GetSection("AppVersion").Value.ToString();
        }
    }
}
