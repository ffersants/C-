using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Result_and_API.DOMAIN.Enums
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
