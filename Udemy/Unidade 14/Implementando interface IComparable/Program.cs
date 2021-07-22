using System;
using System.Collections.Generic;
using System.IO;

namespace Implementando_interface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\DheyEs\Documents\C#\Udemy\Unidade 14\Implementando interface IComparable\test.txt";
            using (StreamReader sr = File.OpenText(path)) 
            {

                List<string> Pessoas = new List<string>();
                while (!sr.EndOfStream)
                {
                    Pessoas.Add(sr.ReadLine());
                }
                Pessoas.Sort();
                Pessoas.ForEach(i => Console.Write("{0}\n", i));

            }
        }
    }
}
