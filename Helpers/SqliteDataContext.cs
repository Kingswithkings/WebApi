using Microsoft.EntityFrameworkCore;

namespace WebApi.Authorization.Helpers
{
    public class SqliteDataContext : DataContext
    {
        public SqliteDataContext(IConfiguration configuration) : base(configuration) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var ConnectionString = Configuration.GetConnectionString("WebApiDatabase");
            // connect to sql server database
            object value = options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}
