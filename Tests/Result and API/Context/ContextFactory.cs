using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Result_and_API.Context;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace API.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost\\SQLEXPRESS;Database=teste;Trusted_Connection=True;";
            //builder that returns a DbContextOptions objet, which has options that allows you 
            //to configure the database connection (and other options) to be used for a context.
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();



            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }

}
