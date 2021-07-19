using System;
using Interface_and_abstract_class.Enums;

namespace Interface_and_abstract_class.Entities
{
    class Rectangle : AbstractShape
    {
        public double width { get; set; }
        public double height { get; set; }
        public Cor cor { get; set; }
        public override double Area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return $"width: {width},\nheight: {height},\ncor:{cor}";
        }
    }
}
