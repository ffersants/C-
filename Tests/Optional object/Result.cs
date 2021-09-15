using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_object
{
    public class Result<T>
    {
        public readonly string status;
        public readonly string message;
        public readonly T? payload;

        public Result(string status, string message, T? payload)
        {
            this.status = status;
            this.message = message;
            this.payload = payload;
        }
    }
}
