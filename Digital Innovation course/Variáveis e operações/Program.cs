using System;

namespace Variáveis_e_operações
{
    class Program
    {
        static void Main()
        {
            int a;
            int b = 5, c = 10;
            const int d = 15;
            a = 1;
            Console.WriteLine(a + b + c + d);

            InstrucaoIf("Hellow world");
        }
        // INSTRUÇÕES DE CONDICIONAL
        static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum parâmetro.");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um parâmetro.");
            }
            else
            {
                Console.WriteLine($"{args.Length} parâmetros.");
            }
        }

        static void InstrucaoSwitch(string[] args)

        {
            int numeroDeArgumentos = args.Length;

            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumento} argumentos");
                    break;
            }
        }


        // INSTRUÇÕES DE REPETIÇÃO
        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstrucaoDo()
        {
            string texto;

            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.isNullOrEmpty(texto));
        }

        static void InstrucaoFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(string[] args)
        {
            foreach (string caracter in args)
            {
                Console.WriteLine(caracter);
            }
        }

        //INSTRUÇÕES PARA CONTROLE DE LAÇÕES DE REPETIÇÃO
        static void InstrucaoBreak()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (string.isNullOrEmpty(input)) break;

                Console.WriteLine(input);
            }
        }

        static void InstrucaoContinue(string[] args)
        {
            for (int i = 0; i != args.Length; i++)
            {
                if (args[i].StartsWith('/'))
                    continue;
                Console.WriteLine($"{args[i]} não inicia com /");
            }
        }

        static void InstrucaoReturn()
        {

            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Somar(1, 1));
            Console.WriteLine(Somar(10, 5));
        }


        // INSTRUÇÃO PARA LIDAR COM EXCEPTIONS
        static void InstrucaoTryCatch(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            try
            {
                if (args.Length != 2)
                    throw new InvalidOperationException("Informe 2 números");

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Fim do programa!")
            }
        }

        static void InstrucaoUsing()
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Testando 123...");
            }
        }
    }
}
