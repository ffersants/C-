using System.Threading.Tasks;
using GraphQL_on_csharp.Data;
using HotChocolate;
using HotChocolate.Data;
using GraphQL_on_csharp.GraphQL.Platforms;
using GraphQL_on_csharp.Models;
using GraphQL_on_csharp.GraphQL.Commands;

namespace GraphQL_on_csharp.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddPlatformPayload> AddPlatformAsync(AddPlatformInput input, [ScopedService] AppDbContext context)
        {
            var platform = new Platform{
                Name = input.name
            };

            context.Platforms.Add(platform);

            await context.SaveChangesAsync();

            return new AddPlatformPayload(platform);
        }

        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddCommandPayload> AddCommandAsync(AddCommandInput input, [ScopedService] AppDbContext context)
        {
            var command = new Command
            {
                CommandLine = input.CommandLine,
                HowTo = input.HowTo,
                PlatformId = input.PlatformId,
            };

            context.Command.Add(command);
            await context.SaveChangesAsync();

            return new AddCommandPayload(command);
        }
    }
}