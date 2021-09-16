using LanguageExt;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Optional_object
{
    public class Service
    {
        private readonly Repository _repository;

        public Service()
        {
            _repository = new Repository();
        }

        public Result<User> GetUser(int id, string nome)
        {
            var result =  _repository.GetUserById(id);
            return result.Match(
                Some: (result) => new Result<User>("OK", "Usuário encontrado.", result),
                None: () => new Result<User>("Error", "Usuário NÃO encontrado.", null));
        }
    }
}