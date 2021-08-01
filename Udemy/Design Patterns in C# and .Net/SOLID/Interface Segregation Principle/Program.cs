using System;

namespace Interface_Segregation_Principle
{
    class Program
    {
        /// <summary>
        /// NÃO RESPEITANDO O ISP
        /// </summary>
        public class Document { }
        //uma interface muito recheada
        interface IGenericPrinter
        {
            string Print(Document p);

            string Scan(Document p);

            string PrintOnTeaCup(Document p);
        }
        //provoca implementações desnecessárias
        public class SimplePrinter : IGenericPrinter
        {
            public string Print(Document p)
            {
                return "Document printed!";
            }
            //código desnecessário
            public string PrintOnTeaCup(Document p)
            {
                return "Method not implemented";
            }
            //código desnecessário
            public string Scan(Document p)
            {
                return "Method not implemented";
            }
        }



        /// <summary>
        /// RESPEITANDO O ISP
        /// </summary>
        /// 
        //interfaces segregadas
        interface IPrinter
        {
            string Print(Document p);
        }
        interface IScanner
        {
            string Scan(Document p);
        }
        interface IPrinterOnTeaCup
        {
            string PrintOnTeaCup(Document p);
        }
        //permitem implementações selecionadas
        public class GoodOldPrinter : IPrinter, IScanner
        {
            public string Scan(Document p) => "Document scanned!";
            public string Print(Document p) => "Document printed!";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
