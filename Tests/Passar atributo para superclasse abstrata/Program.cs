using System;

namespace Passar_atributo_para_superclasse_abstrata
{
    class Program
    {
        public abstract class InternalUser
        {
            public string nome { get; set; }
            public string matricula { get; set; }

            public InternalUser(string nome, string matricula)
            {
                this.nome = nome;
                this.matricula = matricula;
            }
        }

        public class Tecnico : InternalUser { 
            public Tecnico(string nome, string matricula) : base(nome, matricula) { }
        }

        static void Main(string[] args)
        {
            InternalUser eu = new Tecnico("Fernando", "123456");
            //ou 
            //Tecnico eu = new Tecnico("Fernando", "123456");
            Console.WriteLine($"Nome: {eu.nome} \nMatricula: {eu.matricula}");
        }
    }
}
