using Result_and_API.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Result_and_API.DOMAIN.Interfaces.Service
{
    public interface IService
    {
        public Task<Result<Administrator>> FindUserByName(string name);
        public Task<Result<Administrator>> FindUserById(int id);
        public Task<Result<Administrator>> GetAll();

        //public Result<IEnumerable<User>> GetAll();
        //public Result<User> GetById(int id);
        //public Result<User> GetByName(string name);
    }
}
