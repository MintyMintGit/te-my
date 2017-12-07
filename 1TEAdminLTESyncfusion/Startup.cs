using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SyncFusion.Services;
using Microsoft.AspNetCore.Http;
using Westwind.Globalization;
using Westwind.AspNetCore;
using System.Globalization;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Mvc.Localization;
using Westwind.Globalization.AspnetCore;
using Microsoft.AspNetCore.Localization;
using _1TE_MY.Repository;
using _1TE_MY.Services.Interfaces;
using _1TE_MY.Services.Implementations;
using _1TE_MY.Repository.Interfaces;
using _1TE_MY.Repository.Implementations;
using Newtonsoft.Json.Serialization;

namespace _1TEAdminLTESyncfusion
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            Configuration = configuration;
            AutomapperConfig.Configure();

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<_1TEDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IStringLocalizerFactory, DbResStringLocalizerFactory>();
            services.AddSingleton<IHtmlLocalizerFactory, DbResHtmlLocalizerFactory>();
            services.AddWestwindGlobalization(opt =>
            { 
                // Resource Mode - Resx or DbResourceManager                
                opt.ResourceAccessMode = ResourceAccessMode.DbResourceManager;  // ResourceAccessMode.Resx
                 
                opt.ConnectionString = Configuration.GetConnectionString("DefaultConnection");
                 
                opt.ResourceTableName = "localizations";
                opt.AddMissingResources = false;
                opt.ResxBaseFolder = "~/Properties/";

                // Set up security for Localization Administration form
                opt.ConfigureAuthorizeLocalizationAdministration(actionContext =>
                {
                    // return true or false whether this request is authorized
                    return true;   //actionContext.HttpContext.User.Identity.IsAuthenticated;
                });
            });

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IRegistrationRepository, RegistrationRepository>();
            services.AddScoped<IRegistrationService, RegistrationService>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IMasterService, MasterService>();
            services.AddScoped<IMasterRepository, MasterRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc().AddSessionStateTempDataProvider().AddViewLocalization()
                .AddDataAnnotationsLocalization();
            services.AddMvc().AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());


            services.AddTransient<IViewLocalizer, DbResViewLocalizer>();
            services.AddSession();

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseSession();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            var supportedCultures = new[]
            {
                
                new CultureInfo("en"),
                new CultureInfo("ms"),
                
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                // Formatting numbers, dates, etc.
                SupportedCultures = supportedCultures,
                // UI strings that we have localized.
                SupportedUICultures = supportedCultures
            });
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}/{id?}");
            });

        }
    }
}
