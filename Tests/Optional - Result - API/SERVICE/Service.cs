using Optional___Result___API.DOMAIN.Entities;
using Optional___Result___API.DOMAIN.Interfaces.Repository;
using Optional___Result___API.DOMAIN.Interfaces.Service;
using Optional___Result___API.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optional___Result___API.SERVICE
{
    public class Service : IService
    {
        private readonly IRepository repository;

        public Service(IRepository repository)
        {
            this.repository = repository;
        }

        public Result<User> FindUserById(int id)
        {
            var repoResult = repository.GetById(id);

            return repoResult.Match(
               Some: (repoResult) => new Result<User>(ResultEnum.Ok, "Usuário encontrado.", repoResult),
               None: () => new Result<User>(ResultEnum.NotFound, "Usuário NÃO encontrado.", null));

        }

        public Result<User> FindUserByName(string name)
        {
            var repoResult = repository.GetByName(name);

            return repoResult.Match(
               Some: (repoResult) => new Result<User>(ResultEnum.Ok, "Usuário encontrado.", repoResult),
               None: () => new Result<User>(ResultEnum.NotFound, "Usuário NÃO encontrado.", null));
        }

        public Result<User> GetAll()
        {
            var repoResult = repository.GetAll();

            return repoResult.Match(
             Some: (repoResult) => new Result<User>(ResultEnum.Ok, "Usuário encontrado.", repoResult),
             None: () => new Result<User>(ResultEnum.NotFound, "Usuário NÃO encontrado.", null));
        }
    }
}
