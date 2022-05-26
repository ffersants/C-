using System.Threading.Tasks;
using GraphQL_on_csharp.Data;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQL_on_csharp.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddPlatformPayload> AddPlatformAsync(AddPlatformInput input, [ScopedService] AppDbContext)
        {

        }
    }
}