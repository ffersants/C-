using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_object
{
    class Repository
    {
        private readonly IEnumerable<User> userList;

        public Repository()
        {
            userList = new List<User>
            {
                new User(123, "Fernando"),
                new User(456, "Amanda"),
                new User(456, "Ricardo"),
                new User(456, "Letícia"),
            };                
        }

        public User GetUserById(int id)
        {
            return (User)userList.FirstOrDefault(i => i.id.Equals(id));
        }
    }
}
