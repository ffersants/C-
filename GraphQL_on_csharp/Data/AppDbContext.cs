using GraphQL_on_csharp.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_on_csharp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){

        }

        public DbSet<Platform> Platforms {get; set;}
    }
}