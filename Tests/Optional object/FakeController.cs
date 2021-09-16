using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_object
{
    public class FakeController
    {
        private readonly Service _service;
        public FakeController()
        {
            _service = new Service();
        }


        public void GetUser()
        {
            var result = _service.GetUser(123, "Fernando");



            Console.WriteLine(result.status);
            Console.WriteLine(result.message);
            Console.WriteLine($"Nome: {result.payload?.id}");
            Console.WriteLine($"Matrícula: {result.payload?.nome}");
        }

    }
}
