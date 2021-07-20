using System;

namespace Conversão_implícita_e_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //tudo ok - 32bits (int) cabem em 64 (double)
            int a = 10;
            double b = a;
            Console.WriteLine(b);

            //não é possível converter implicitamente, logo, deve-se realizar um casting
            double x = 50;
            int y = x as int;
            Console.WriteLine(y);

            //divisão entre inteiros resulta em inteiro
            int d = 5;
            int e = 2;
            //casting para forçar a presença da casa decimal... Int / double = double
            Console.WriteLine((double)d/e);
        }
    }
}
