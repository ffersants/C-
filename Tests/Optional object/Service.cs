using Microsoft.EntityFrameworkCore;
using System;
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

        public void GetUserById(int id)
        {
            var searchResult =  _repository.GetUserById(id);
            Console.WriteLine(searchResult);
            var response = new Optional<User>(searchResult);

            Console.WriteLine(response.Value);

            //Console.WriteLine(searchResult.nome);
        }
    }
}