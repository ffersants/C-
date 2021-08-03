using System;

namespace Lidando_com_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o valor 1: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor 2: ");
                int num2 = int.Parse(Console.ReadLine());

                double result = num1 / num2;
                Console.Write($"O resultado de {num1} / {num2} é igual a {result}");
            }
            //captura divisão por 0
            catch (DivideByZeroException operacaoInvalida)
            {
                Console.WriteLine("Não é possível dividir um valor por 0.");
                Console.WriteLine(operacaoInvalida.Message);
            }
            catch (FormatException valorInvalido)
            {
                Console.WriteLine("Por favor, digite um valor válido.");
                Console.WriteLine(valorInvalido.Message);
            }

        }
    }
}
