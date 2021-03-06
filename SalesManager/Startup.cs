using Microsoft.EntityFrameworkCore;
using SalesManager.Models;
using SalesManager.Services;
using SalesManager.Data;
namespace SalesManager;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();

        services.AddDbContext<SalesManagerContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SalesManagerContext")));
        
        services.AddScoped<SeedingService>();
        services.AddScoped<SellerService>();
        services.AddScoped<DepartmentService>();
        services.AddScoped<SalesRecordService>();
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, SeedingService seedingService)
    {
        var enUS = new CultureInfo("en-US");
        var localizationOptions = new RequestLocalizationOptions
        {
            DefaultRequestCulture = new RequestCulture(enUS),
            SupportedCultures = new List<CultureInfo> { enUS },
            SupportedUICultures = new List<CultureInfo> { enUS }
        };

        app.UseRequestLocalization(localizationOptions);

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            seedingService.Seed();

        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
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