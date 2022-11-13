namespace StillsApp;

using Microsoft.EntityFrameworkCore;
using StillsApp.DL;

public partial class DataContext : DbContext
//SOLID Single Responsibility Principle: both production and development database contexts have a configuration with a single responsibility encapsulated within that context
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

    //SOLID Single Responsibility Principle: All DbSets have a single responsibility encapsulated within that DbSet, comprising a single table, entity, and class definition
    //SOLID Dependency Inversion Principle: By using Entity Framework and underlying DbSets, higher level classes depend on abstraction instead of low level classes.
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