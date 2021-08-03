using System;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando lista vazia
            List<string> listaDeAlunos = new List<string>();
            //instanciando lista já com itens
            List<string> listaDeAlunos2 = new List<string> {
                "Fernando", 
                "Igor", 
                "Amanda", 
                "Carol", 
                "João",
                "Carlos",
                "Fábio",
                "Icaro"};

            //adicionar itens à lista
            listaDeAlunos.Add("Coca cola");

            //tamanho da lista
            Console.WriteLine(listaDeAlunos2.Count);

            //remover item de um index específico
            listaDeAlunos2.RemoveAt(7);
            PrintList(listaDeAlunos2, "removeAt()");

            //verifica a existência de um item na lista
            bool doesAlmirExists = listaDeAlunos2.Exists(x => x == "Almir");
            bool doesFernandoExists = listaDeAlunos2.Exists(x => x == "Almir");
            Console.WriteLine(doesFernandoExists);
            Console.WriteLine(doesAlmirExists);
        }

        static void PrintList(List<string> minhaLista, string methodUsed)
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------");
            Console.WriteLine("ACTION: " + methodUsed);

            foreach(string listItem in minhaLista)
            {
                Console.WriteLine(listItem);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("");
        }
    }
}
