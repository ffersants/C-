using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
    }
}