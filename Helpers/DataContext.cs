namespace WebApi.Authorization.Helpers;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApi.Entities;

    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        // connect to sql server database
        object value = options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<User> Users { get; set; }
    }

