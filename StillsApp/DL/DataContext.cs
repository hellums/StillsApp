namespace StillsApp;

using Microsoft.EntityFrameworkCore;
using StillsApp.DL;

public partial class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server database
        options
            .EnableSensitiveDataLogging()
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
            .UseSqlServer(Configuration.GetConnectionString("StillsAppDB"));
    }

    public DbSet<Owner>? Owners { get; set; }
    public DbSet<Distillery>? Distilleries { get; set; }
    public DbSet<Address>? Addresses { get; set; }
    public DbSet<Brand>? Brands { get; set; }
    public DbSet<Experience>? Experiences { get; set; }
    public DbSet<Ticket>? Tickets { get; set; }
    public DbSet<Photo>? Photos { get; set; }
    public DbSet<Review>? Reviews { get; set; }
    public DbSet<Recipe>? Recipes { get; set; }
}