using System;

namespace Class_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa fernando = new Pessoa(2000);
            Console.WriteLine(Pessoa.getAge(fernando.birthYear));
        }
    }
}
