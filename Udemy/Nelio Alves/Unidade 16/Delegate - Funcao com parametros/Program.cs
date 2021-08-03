using System;

namespace Delegate___Multicast_e_funcao_invoke
{
    class Program
    {
        //PART 1 - Assinatura de como deve ser um método delegate ConsoleActions
        public delegate void ConsoleActions();
        //PART 2 - Método que recebe função com delegate ConsoleActions como parâmetro
        static void MainFunc(ConsoleActions delegateResolved)
        {
            delegateResolved();
        }
        //PART 3 - Função que resolve o delegate ConsoleActions
        static void method1(string msg)
        {
            Console.WriteLine($"Executado método 1 {msg}");

        }
        static void Main(string[] args)
        {
            //Instância da função delegate com passagem de parâmetro
            ConsoleActions delegateFunc = new ConsoleActions(() => method1("sei la"));
            //PART 4 - Chamando a o método e passando a função delegate 
            MainFunc(delegateFunc);
        }
    }
}
