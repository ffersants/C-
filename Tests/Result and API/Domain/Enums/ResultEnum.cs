using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Result_and_API.DOMAIN.Enums
{
    public enum ResultEnum
    {
        Ok = 200,
        BadRequest = 404,
        Unauthorized = 401,
        Created = 201,
        NotFound = 404,
        Forbidden = 403,
        Conflict = 409
    }
}
