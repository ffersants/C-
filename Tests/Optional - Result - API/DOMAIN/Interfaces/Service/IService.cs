using Optional___Result___API.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Optional___Result___API.DOMAIN.Interfaces.Service
{
    public interface IService
    {
        public Result<User> FindUserByName(string name);
        public Result<User> FindUserById(int id);
        public Result<User> GetAll();

        //public Result<IEnumerable<User>> GetAll();
        //public Result<User> GetById(int id);
        //public Result<User> GetByName(string name);
    }
}
