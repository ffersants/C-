using LanguageExt;
using Optional___Result___API.DOMAIN.Entities;
using System.Collections.Generic;

namespace Optional___Result___API.DOMAIN.Interfaces.Repository
{
    public interface IRepository
    {
        public Option<User> GetById(int id);
        public Option<User> GetByName(string name);
        public Option<IEnumerable<User>> GetAll();
    }
}
