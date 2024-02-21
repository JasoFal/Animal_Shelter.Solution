using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Animal_Shelter.Models;

namespace Animal_Shelter
{
  class Program
  {
    static void Main(string[] arg)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(arg);
      builder.Services.AddControllersWithViews();
      builder.Services.AddDbContext<AnimalShelterContext>(
        dbContextOptions => dbContextOptions
          .UseMySql(
            builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
          )
        )
      );
      WebApplication app = builder.Build();
      // app.UseDeveloperExceptionPage();
      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseRouting();
      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );
      app.Run();
    }
  }
}