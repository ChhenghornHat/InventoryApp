using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc();
            services.AddSession();
            
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddProgressiveWebApp();
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
            Models.Classes.ConnectionString.QueryBrand = Configuration.GetSection("QueryBrand").Value.ToString();
            Models.Classes.ConnectionString.QueryCategory = Configuration.GetSection("QueryCategory").Value.ToString();
            Models.Classes.ConnectionString.QuerySubCategory = Configuration.GetSection("QuerySubCategory").Value.ToString();
            Models.Classes.ConnectionString.QueryItemList= Configuration.GetSection("QueryItemList").Value.ToString();
            Models.Classes.ConnectionString.ImageUrl = Configuration.GetSection("ImageUrl").Value.ToString();
            
            Models.Classes.ConnectionString.ApiUrl = Configuration.GetSection("ApiUrl").Value.ToString();
            Models.Classes.ConnectionString.ApiAuth = Configuration.GetSection("ApiAuth").Value.ToString();
            
            Models.Classes.ConnectionString.AppName = Configuration.GetSection("AppName").Value.ToString();
            Models.Classes.ConnectionString.AppInfo = Configuration.GetSection("AppInfo").Value.ToString();
            Models.Classes.ConnectionString.AppVersion = Configuration.GetSection("AppVersion").Value.ToString();
            
            Models.Classes.ConnectionString.ChatId = Configuration.GetSection("ChatId").Value.ToString();
            Models.Classes.ConnectionString.Token = Configuration.GetSection("Token").Value.ToString();
        }
    }
}
