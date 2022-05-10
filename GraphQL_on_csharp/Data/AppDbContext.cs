using GraphQL_on_csharp.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_on_csharp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){

        }

        public DbSet<Platform> Platforms {get; set;}
        public DbSet<Command> Command {get; set;}
    
        protected override void OnModelCreating(ModelBuilder model){
            model.Entity<Platform>()
                .HasMany(i => i.Commands)
                .WithOne(i => i.Platform!)
                .HasForeignKey(i => i.PlatformId);

            model.Entity<Command>()
                .HasOne(i => i.Platform)
                .WithMany(i =>  i.Commands)
                .HasForeignKey(i => i.Id);
        }
    }
}