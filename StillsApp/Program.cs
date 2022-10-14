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

            // Add DI services to the container.
            services.AddScoped<IDistilleryService, DistilleryService>();
            //services.AddTransient<IDistilleryService, DistilleryService>();

            //Web pages
            services.AddRazorPages();
            services.Configure<RazorPagesOptions>
            (options => options.RootDirectory = "/UI/Pages");

            //API controllers
            services.AddControllers();

            if (env.IsProduction())
                services.AddDbContext<DataContext>();
            else
                services.AddDbContext<DataContext, SqliteDataContext>();

            services.AddSwaggerGen(opt =>
                {
                    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "StillsAPI", Version = "v1" });
                });

    
        var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                app.UseDeveloperExceptionPage();
            }

            // migrate any database changes on startup (includes initial db creation)
            using (var scope = app.Services.CreateScope())
            {
                var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
                dataContext.Database.Migrate();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Parts API v1"));

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.MapControllers();

            app.Run();
        }
    }
}