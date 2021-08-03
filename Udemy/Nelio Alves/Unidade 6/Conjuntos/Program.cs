using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> _nomesA = new List<string> { "Fernando", "Ana", "João", "Larissa", "Carlos", "Jaqueline" };
            List<string> _nomesB = new List<string> { "Jaqueline", "Maurício", "Pedro", "Fernando", "João" };
            
            HashSet<string> nomesA = new HashSet<string>();
            foreach(string name in _nomesA)
            {
                nomesA.Add(name);
            }
            
            HashSet<string> nomesB = new HashSet<string>();
            foreach(string name in _nomesB)
            {
                nomesB.Add(name);
            }

            Console.WriteLine(nomesB.Contains("Fernando"));
            //remove de A tudo o que pertence a B
            {
                nomesA.ExceptWith(nomesB);
            }
            //adicionar em A tudo o que está em B mas não está em A
            {
                nomesA.UnionWith(nomesB);
            }
            //retorna tudo o que está tanto em A quanto em B
            {
                nomesA.IntersectWith(nomesB);
            }
        }
    }
}
