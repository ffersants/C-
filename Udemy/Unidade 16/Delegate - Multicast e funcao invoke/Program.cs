using System;

namespace Delegate___Multicast_e_funcao_invoke
{
    class Program
    {
        public delegate void ConsoleActions();
        static void Main(string[] args)
        {
            ConsoleActions delegateFunc = new ConsoleActions(method1);
            delegateFunc += method2;
            delegateFunc.Invoke();
        }
        static void method1()
        {
            Console.WriteLine("Executado método 1");
        }
        static void method2()
        {
            Console.WriteLine("Executado método 2");
        }
    }
}
