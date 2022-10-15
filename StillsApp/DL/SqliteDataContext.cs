namespace StillsApp;

using Microsoft.EntityFrameworkCore;

public partial class DataContext
{
    public class SqliteDataContext : DataContext
    {
        public SqliteDataContext(IConfiguration configuration) : base(configuration) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("StillsAppDB"));
        }
    }
}