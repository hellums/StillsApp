namespace StillsApp;

using Microsoft.EntityFrameworkCore;
using StillsApp.DL;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
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