using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Fernando", "Igor", "Amanda", "Lucas", "Carla", "Amanda", "Carol", "Raimundo" };
            //retorna nomes com total de caracteres < 6
            var shortNames = names.Where(name => name.Length < 6);
            
            foreach(var name in shortNames)
            {
                Console.WriteLine(name);
            }

            var namesInUpper = shortNames.Select(name => name.ToUpper());
            foreach (var name in shortNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
