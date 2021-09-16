using Optional___Result___API.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optional___Result___API.DOMAIN.Entities
{
    public class Result<T>
    {
        public readonly ResultEnum status;
        public readonly string message;
        public readonly object payload;

        public Result(ResultEnum status, string message, object? payload)
        {
            this.status = status;
            this.message = message;
            this.payload = payload;
        }
    }
}
