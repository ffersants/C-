using System;
using System.IO;
namespace File___Read_file_content
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\DheyEs\Videos\teste1.txt";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadLine());
            fs.Close();
            sr.Close();
            /*
            StreamReader sr = null;
            sr = File.OpenText(@"C:\Users\DheyEs\Videos\teste1.txt");
            Console.WriteLine(sr.ReadLine());
            */
        }
    }
}
