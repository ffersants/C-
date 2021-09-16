using Result_and_API.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Result_and_API.DOMAIN.Entities
{
    public class Result<T>
    {
        public ResultEnum status { get; }
        public string message { get; }
        public object payload { get; }

        public Result(ResultEnum status, string message, object payload)
        {
            this.status = status;
            this.message = message;
            this.payload = payload;
        }
    }
}
