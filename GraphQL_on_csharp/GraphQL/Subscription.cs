using GraphQL_on_csharp.Models;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_on_csharp.GraphQL
{
    public class Subscription
    {
        [Topic]
        [Subscribe]
        public Platform OnPlatformAdd([EventMessage] Platform platform) => platform;
    }
}
