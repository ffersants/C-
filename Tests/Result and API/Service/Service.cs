using Result_and_API.DOMAIN.Entities;
using Result_and_API.DOMAIN.Interfaces.Repository;
using Result_and_API.DOMAIN.Interfaces.Service;
using Result_and_API.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Result_and_API.SERVICE
{
    public class Service : IService
    {
        private readonly IRepository repository;

        public Service(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Result<Administrator>> FindUserById(int id)
        {
            var repoResult = await repository.GetById(id);

            return repoResult.Match(
               Some: (repoResult) => new Result<Administrator>(ResultEnum.Ok, $"Usuário com ID {id} encontrado.", repoResult),
               None: () => new Result<Administrator>(ResultEnum.NotFound, $"Não há usuário registrado com o ID {id}.", null));
        }

        public async Task<Result<Administrator>> FindUserByName(string name)
        {
            var repoResult = await repository.GetByName(name);

            return repoResult.Match(
               Some: (repoResult) => new Result<Administrator>(ResultEnum.Ok, $"Usuário {name} encontrado.", repoResult),
               None: () => new Result<Administrator>(ResultEnum.NotFound, $"Usuário {name} não encontrado.", null));
        }

        public async Task<Result<Administrator>> GetAll()
        {
            var repoResult = await repository.GetAll();

            return repoResult.Match(
             Some: (repoResult) => new Result<Administrator>(ResultEnum.Ok, $"No total há {repoResult.Length()} registro(s) realizado(s).", repoResult),
             None: () => new Result<Administrator>(ResultEnum.NotFound, "Não há cadastros realizados.", null));
        }
    }
}
