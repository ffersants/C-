using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_object
{
    public class User
    {
        public readonly int id;
        public readonly string nome;

        public User(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}
