using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optional___Result___API.DOMAIN.Entities
{
    public class User
    {
        public readonly string Name;
        public readonly int Id;

        public User(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}
