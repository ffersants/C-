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

                List<Servidor> Pessoas = new List<Servidor>();
                while (!sr.EndOfStream)
                {
                    Pessoas.Add(new Servidor(sr.ReadLine()));
                }
                Pessoas.Sort();
                Pessoas.ForEach(i => Console.WriteLine(i.ToString()));
            }
        }
    }
}
