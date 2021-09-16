using LanguageExt;
using Optional___Result___API.DOMAIN.Entities;
using Optional___Result___API.DOMAIN.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DATA
{
    public class Repository : IRepository
    {
        private readonly List<User> dataset;

        public Repository()
        {
            dataset = new List<User>
        {
            new User(123, "Fernando"),
            new User(456, "Amanda"),
            new User(456, "Ricardo"),
            new User(456, "Letícia"),
        };
        }

        public Option<IEnumerable<User>> GetAll()
        {
            return dataset.ToList();
        }

        public Option<User> GetById(int id)
        {
            return dataset.Where(i => i.Id.Equals(id)).SingleOrDefault();
        }

        public Option<User> GetByName(string name)
        {
            return dataset.Where(i => i.Name.Equals(name)).SingleOrDefault();
        }


        /// <summary>
        /// Repositório realiza a verificação do Option e retorna o Result
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /*
        public Result<User> GetById(int id)
        {
            var result = dataset.Where(i => i.Id.Equals(id)).SingleOrDefault();
            result.Match(
                Some: (result) => new Result<User>("OK", "Usuário encontrado.", result),
                None: () => new Result<User>("Error", "Usuário NÃO encontrado.", null))
        }

        public Result<User> GetByName(string name)
        {
           var result = dataset.Where(i => i.Name.Equals(name)).SingleOrDefault();

            result.Match(
                Some: (result) => new Result<User>("OK", "Usuário encontrado.", result),
                None: () => new Result<User>("Error", "Usuário NÃO encontrado.", null));
        }
        */
    }
}
