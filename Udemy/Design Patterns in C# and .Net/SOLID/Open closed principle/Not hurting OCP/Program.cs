using System;
using System.Collections.Generic;

namespace Not_hurting_OCP
{
    public enum Color
    {
        Red, Green, Yellow
    }

    public enum Size
    {
        Small, Medium, Large, Yuge
    }

    public class Product
    {
        public string Name;
        public Size Size;
        public Color Color;

        public Product(string name, Size size, Color color)
        {
            Name = name;
            Size = size;
            Color = color;
        }
    }

    public interface ISpecification<T> { bool IsSatisfied(T t); }
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> fullList, ISpecification<T> filterLogic);
    }

    public class ColorAndSizeSepecification : ISpecification<Product>
    {
        private Color color;
        private Size size;
        public ColorAndSizeSepecification(Color color, Size size)
        {
            this.color = color;
            this.size = size;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Color == color && product.Size == size;          
        }
    }
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;
        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Color == color;
        }
    }
    public class MainFilter : IFilter<Product>
    {
        //já resolve a interface IFilter
        public IEnumerable<Product> Filter(IEnumerable<Product> produtos, ISpecification<Product> colorSpecification)
        {
            foreach (var produto in produtos)
            {
                //irá executar a verificação booleana no método IsSatisfied da classe customizada
                //para filtragem que implementou a interface ISpecification
                if (colorSpecification.IsSatisfied(produto))
                {
                    yield return produto;
                }

            }
        }
    }
    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product produto)
        {
            return produto.Size == size;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product apple = new Product("Apple", Size.Small, Color.Red);
            Product pineapple = new Product("Pineapple", Size.Large, Color.Yellow);
            Product grape = new Product("Grape", Size.Small, Color.Red);
            Product banana = new Product("Banana", Size.Medium, Color.Yellow);
            Product strawberry = new Product("Strawberry", Size.Medium, Color.Red);
            Product watermelon = new Product("Watermelon", Size.Yuge, Color.Green);

            Product[] produtos = { apple, pineapple, grape, banana, strawberry, watermelon };

            MainFilter mainFilter = new MainFilter();

            IEnumerable<Product> onlyRed = mainFilter.Filter(produtos, new ColorSpecification(Color.Red));
            Console.WriteLine("Only red products:");
            foreach (var i in onlyRed) Console.WriteLine(i.Name.ToString());
            
            IEnumerable<Product> onlyMedium = mainFilter.Filter(produtos, new SizeSpecification(Size.Medium));
            Console.WriteLine("\nOnly medium products:");
            foreach (var i in onlyMedium) Console.WriteLine(i.Name.ToString());

            IEnumerable<Product> onlyMediumAndYellow = mainFilter.Filter(produtos, new ColorAndSizeSepecification(Color.Yellow, Size.Medium));
            Console.WriteLine("\nOnly medium and yellow products:");
            foreach (var i in onlyMediumAndYellow) Console.WriteLine(i.Name.ToString());
        }
    }
}
