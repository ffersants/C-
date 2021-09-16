using LanguageExt;
using Microsoft.EntityFrameworkCore;
using Result_and_API.Context;
using Result_and_API.DOMAIN.Entities;
using Result_and_API.DOMAIN.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATA
{
    public class Repository : IRepository
    {
        protected readonly MyContext _context;
        private DbSet<Administrator> _dataset;
        public Repository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<Administrator>();
        }

        public async Task<Option<IEnumerable<Administrator>>> GetAll()
        {
            return await _dataset.ToListAsync();
        }

        public async Task<Option<Administrator>> GetById(int id)
        {
            return await _dataset.FirstOrDefaultAsync(i => i.ID.Equals(id));
        }

        public async Task<Option<Administrator>> GetByName(string name)
        {
            return await _dataset.FirstOrDefaultAsync(i => i.Name.Equals(name)); ;
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
