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
            var builder = WebApplication.CreateBuilder(new WebApplicationOptions
            {
                Args = args,
                // Look for static files in "UI/wwwroot" folder
                WebRootPath = "UI/wwwroot"
            });
            var env = builder.Environment;
            var services = builder.Services;

            // Configure the DI service containers
            if (env.IsProduction())
                //launch SQL Server db service
                services.AddDbContext<DataContext>();
            else
                //launch Sqlite db service
                services.AddDbContext<DataContext, SqliteDataContext>(); //SOLID Open-Closed Principle: By using an interface inheritance, the details of the underlying physical database interface can be implemented and changed without modifying the base class.

            services.AddTransient<IDistilleryService, DistilleryService>();

            services.AddControllers();

            services.AddSwaggerGen(opt =>
                {
                    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "StillsAPI", Version = "v1" });
                });

            services.AddRazorPages();
            //SOLID Dependency Inversion Principle: By separating User Interaction from the Data Layer and Business Logic, all classes and details depend on abstraction, and high-level classes do not depend on low level classes.
            services.Configure<RazorPagesOptions>
                (options => options.RootDirectory = "/UI/Pages");
    
        var app = builder.Build();

            // Migrate the database used by current profile, dev or production
            using (var scope = app.Services.CreateScope())
            {
                var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
                dataContext.Database.Migrate(); //SOLID Single Responsibility Principle:  both production and development database contexts have a configuration with a single responsibility encapsulated within that context

            }

            // Configure the app and HTTP request pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseDeveloperExceptionPage();
            }

            app.MapControllers();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Parts API v1"));

            app.UseStaticFiles();
            app.MapRazorPages();

            app.UseRouting();
            app.UseAuthorization();

            app.Run();
        }
    }
}