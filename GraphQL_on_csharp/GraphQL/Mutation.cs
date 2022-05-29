using System.Threading.Tasks;
using GraphQL_on_csharp.Data;
using HotChocolate;
using HotChocolate.Data;
using GraphQL_on_csharp.GraphQL.Platforms;
using GraphQL_on_csharp.Models;
using GraphQL_on_csharp.GraphQL.Commands;
using HotChocolate.Subscriptions;
using System.Threading;

namespace GraphQL_on_csharp.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddPlatformPayload> AddPlatformAsync(AddPlatformInput input, 
            [ScopedService] AppDbContext context,
            [Service] ITopicEventSender eventSender,
            CancellationToken cancellationToken
        )
        {
            var platform = new Platform{
                Name = input.name
            };

            context.Platforms.Add(platform);

            await context.SaveChangesAsync();

            await eventSender.SendAsync(nameof(Subscription.OnPlatformAdd), platform, cancellationToken);

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