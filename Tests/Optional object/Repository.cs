using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_object
{
    public class Repository
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

        public Option<User> GetUserById(int id)
        {
            Option<User> userOrDefault = userList.Where(i => i.id.Equals(id)).SingleOrDefault();
            return userOrDefault;
            
        }
    }
}
