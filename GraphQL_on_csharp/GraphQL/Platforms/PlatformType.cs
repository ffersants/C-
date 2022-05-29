using System;
using System.Linq;
using GraphQL_on_csharp.Data;
using GraphQL_on_csharp.Models;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQL_on_csharp.GraphQL.Platforms {
    public class PlatformType : ObjectType<Subscription> {
        protected override void Configure(IObjectTypeDescriptor<Subscription> descriptor)
        {
            //legenda do schema
            descriptor.Description("Represents a software");

            descriptor.Field(i => i.LicenseKey).Ignore();
        
            descriptor.Field(i => i.Commands)
                .ResolveWith<Resolvers>(p => p.GetCommands(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the list of commands for this platform.");
            //altera o nome de um campo
            descriptor.Field(i => i.Name).Name("PlatformName");
        }

        private class Resolvers {
            public IQueryable<Command> GetCommands([Parent] Subscription platform, [ScopedService] AppDbContext context) {
                return context.Command.Where(p => p.PlatformId == platform.Id);
            }
        }
    }
}