using System;

namespace Liskov_Substitution_Principle
{
    class Program
    {
        public class Rectangle
        {
            public int width { get; set; }
            public int height { get; set; }
            public Rectangle() { }
            public Rectangle(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public int Area() => width * height;

            public override string ToString()
            {
                return $"Width: {width}  |  Height: {height}";
            }
        }

        public class Square : Rectangle
        {
            public Square(int value) : base(value, value) { }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.width = 8;
            r.height = 5;
            Console.WriteLine(r.ToString());
            Console.WriteLine(r.Area());

            Rectangle s = new Square(5);
        
            Console.WriteLine();
            Console.WriteLine(s.ToString());
            Console.WriteLine(s.Area());
        }
    }
}
