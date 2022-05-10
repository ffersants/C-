using System.Linq;
using GraphQL_on_csharp.Data;
using GraphQL_on_csharp.Models;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQL_on_csharp.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]

        public IQueryable<Command> GetContext([ScopedService] AppDbContext context)
        {
            return context.Command;
        }

    }
}