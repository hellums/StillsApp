namespace StillsApp;

using Microsoft.EntityFrameworkCore;

public partial class DataContext
{
    public class SqliteDataContext : DataContext //SOLID Open-Closed Principle: By using an interface inheritance, the details of the underlying physical database interface can be implemented and changed without modifying the base class.

        public SqliteDataContext(IConfiguration configuration) : base(configuration) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options
                .EnableSensitiveDataLogging()
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .UseSqlite(Configuration.GetConnectionString("StillsAppDB"));
        }
    }
}