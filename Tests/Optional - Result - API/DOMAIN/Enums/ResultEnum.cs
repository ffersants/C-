using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optional___Result___API.DOMAIN.Enums
{
    public enum ResultEnum
    {
        Ok,
        Invalid,
        Unauthorized,
        PartialOk,
        NotFound,
        PermissionDenied,
        Unexpected
    }
}
