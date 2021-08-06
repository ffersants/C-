using Iniciando___Factory_Method.Classes;
using Iniciando___Factory_Method.Classes.Base;
using Iniciando___Factory_Method.Factory;
using System;

namespace Iniciando___Factory_Method
{
   
    class Program
    {
        static void Main(string[] args)
        {

            PapelariaProduct papel = Factory.createPaper();
            papel.productName = "Folha de papel";
            Console.WriteLine(papel.productName);
        }
       
    }
}
