using System;

namespace Boxing_e_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando um tipo por valor 
            int valor = 10;
            //o fato de chamar o método GetType() obriga o Boxing 
            valor.GetType();

            //BOXING
            int x = 10;
            Object obj = x;

            //UNBOXING
            int z = (int)obj;

            int i = 123;
            //boxing realizado para melhoria do desempenho, sem ele, serão realizados
            //3 boxings seguidos na linha do console.write
            Object a = i;
            Console.WriteLine("valor: " + a + a + a);
        }

    }
}
