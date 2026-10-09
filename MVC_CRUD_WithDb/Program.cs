using Microsoft.EntityFrameworkCore;
using MVC_CRUD_WithDb.Context;
using MVC_CRUD_WithDb.Services;

namespace MVC_CRUD_WithDb;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<SchoolDbContext>(options
            =>options.UseSqlServer(builder.Configuration
            .GetConnectionString("SchoolConnection")));

        builder.Services.AddScoped<IStudentServices, StudentServices>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}")
            .WithStaticAssets();

        app.Run();
    }
}
