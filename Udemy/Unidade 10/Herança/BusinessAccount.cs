using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class BusinessAccount : Account 
    {
        public BusinessAccount(int number, string holder, double balance) : base(number, holder, balance)
        {

        }
    }
}
