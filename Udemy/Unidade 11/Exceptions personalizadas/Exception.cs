using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_personalizadas
{
    class Exception : ApplicationException
    {
        public Exception(string errorMsg) : base(errorMsg) { }
    }
}
