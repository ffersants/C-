using System;
using Interface_and_abstract_class.Enums;

namespace Interface_and_abstract_class.Entities
{
    abstract class AbstractShape : IShape
    {
        public Cor color;
        public abstract double Area();
    }
}
