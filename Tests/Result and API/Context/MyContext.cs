
using Microsoft.EntityFrameworkCore;
using Result_and_API.DOMAIN.Entities;

namespace Result_and_API.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Administrator> Administrator { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Administrator>().HasKey(i => i.ID);
        }

    }
}
