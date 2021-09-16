using LanguageExt;
using Result_and_API.DOMAIN.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Result_and_API.DOMAIN.Interfaces.Repository
{
    public interface IRepository
    {
        public Task<Option<IEnumerable<Administrator>>> GetAll();
        public Task<Option<Administrator>> GetById(int id);
        public Task<Option<Administrator>> GetByName(string name);
    }
}
