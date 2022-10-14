using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using StillsApp.BL;
using static StillsApp.DataContext;

namespace StillsApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var env = builder.Environment;
            var services = builder.Services;

            // Configure the DI service containers
            services.AddDbContext<DataContext, SqliteDataContext>();

            services.AddTransient<IDistilleryService, DistilleryService>();

            services.AddControllers();

            services.AddSwaggerGen(opt =>
                {
                    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "StillsAPI", Version = "v1" });
                });

            services.AddRazorPages();
            services.Configure<RazorPagesOptions>
            (options => options.RootDirectory = "/UI/Pages");
    
        var app = builder.Build();

            // Configure the app and HTTP request pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
                app.UseDeveloperExceptionPage();
            }

            app.MapControllers();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Parts API v1"));
            app.MapRazorPages();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();


            app.Run();
        }
    }
}