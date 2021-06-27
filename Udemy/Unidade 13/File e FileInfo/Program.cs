using System;
using System.IO;
namespace File_e_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileInfo txt1 = new FileInfo(@"C:\Users\DheyEs\Videos\teste1.txt");
                txt1.CopyTo(@"C:\Users\DheyEs\Videos\teste2.txt");
            }

            catch(SystemException e)
            {
                Console.WriteLine("Opa... Deu erro aqui!");
                Console.WriteLine(e);
            }
        }
    }
}
