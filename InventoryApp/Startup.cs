using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.AspNetCore.Authentication.Cookies;

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
            services.AddSession();
            services.AddControllersWithViews();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddRouting(options => options.LowercaseUrls = true);
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
            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
                    // pattern: "{controller=Admin}/{action=AdminDashboard}/{id?}");
            });
            Models.Classes.ConnectionString.Constr = Configuration.GetSection("ConnectionString").Value.ToString();
            Models.Classes.ConnectionString.Constr = Configuration.GetSection("ConnectionString").Value.ToString();
            Models.Classes.ConnectionString.Constr2 = Configuration.GetSection("ConnectionString2").Value.ToString();
            Models.Classes.ConnectionString.Server = Configuration.GetSection("ServerName").Value.ToString();
            Models.Classes.ConnectionString.UserId = Configuration.GetSection("UserID").Value.ToString();
            Models.Classes.ConnectionString.Password = Configuration.GetSection("Password").Value.ToString();

            Models.Classes.ConnectionString.QueryDatabase = Configuration.GetSection("QueryDatabase").Value.ToString();
            Models.Classes.ConnectionString.QueryCategory = Configuration.GetSection("QueryCategory").Value.ToString();
            Models.Classes.ConnectionString.QuerySubCategory = Configuration.GetSection("QuerySubCategory").Value.ToString();
            Models.Classes.ConnectionString.ImageUrl = Configuration.GetSection("ImageUrl").Value.ToString();
            
            Models.Classes.ConnectionString.AppName = Configuration.GetSection("AppName").Value.ToString();
            Models.Classes.ConnectionString.AppInfo = Configuration.GetSection("AppInfo").Value.ToString();
            Models.Classes.ConnectionString.AppVersion = Configuration.GetSection("AppVersion").Value.ToString();
        }
    }
}
