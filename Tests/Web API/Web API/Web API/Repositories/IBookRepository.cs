using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int id);
        Task<Book> Create(Book book);
        Task Update(Book book);
        Task Delete(int id);
    }
}
