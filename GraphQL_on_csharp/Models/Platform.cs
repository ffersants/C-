using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace GraphQL_on_csharp.Models
{
    [GraphQLDescription("Represents a program or service that has CLI")]
    public class Platform
    {
        [Key]
        public int Id {get; set; }
        
        [Required]
        public string Name {get; set; }

        [GraphQLDescription("Represents a valid license")]   
        public string LicenseKey { get; set; }

        public ICollection<Command> Commands {get; set;} = new List<Command>();
    }
}