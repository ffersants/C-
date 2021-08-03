using System;

namespace Delegate
{
    class Program
    {

        static string implementsSignature(string a)
        {
            return $"Mensagem do log {a}";
        }

        public delegate string delegateSignature(string txt);

        static void functionToCall(delegateSignature funcWithDelegateImplemented, string toPassToDelegate)
        {
            Console.WriteLine("[STARTED]");
            Console.WriteLine(funcWithDelegateImplemented(toPassToDelegate));
            Console.WriteLine("[FINISHED]");
        }
        static void Main(string[] args)
        {
            
            //delegateSignature signatureResolved = new delegateSignature(implementsSignature);

            functionToCall(implementsSignature, "oijfds");
        }


        

       
    }
}
