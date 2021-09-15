using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_object
{
    public class DataNotFound
    {
        private readonly ResultType ResultType;
        private readonly string Message;

        public DataNotFound(ResultType resultType, string message)
        {
            ResultType = resultType;
            Message = message;
        }
    }
}

