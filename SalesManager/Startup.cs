using Microsoft.EntityFrameworkCore;
using SalesManager.Models;
namespace SalesManager;
using SalesManager.Data;
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
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, SeedingService seedingService)
    {

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