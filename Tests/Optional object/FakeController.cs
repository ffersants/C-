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


        public void GetUserById(int id)
        {
            _service.GetUserById(id);
        }

    }
}
