using System.Linq;
using GraphQL_on_csharp.Data;
using GraphQL_on_csharp.Models;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQL_on_csharp.GraphQL.Commands
{
    public class CommandType : ObjectType<Command>
    {
        protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
        {
            descriptor.Field(f => f.Platform)
            .ResolveWith<Resolver>(r => r.GetPlatform(default!, default!))
            .UseDbContext<AppDbContext>();
        }
        private class Resolver
        {
            public Subscription GetPlatform([Parent] Command command, [ScopedService] AppDbContext context)
            {
                return context.Platforms.FirstOrDefault(p => p.Id == command.PlatformId);
            }
        }
    }

}