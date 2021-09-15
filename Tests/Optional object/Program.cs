using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Optional_object
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeController controller = new FakeController();
            controller.GetUserById(1423423);
        }

       

}
}
