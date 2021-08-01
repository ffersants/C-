using System;
using System.Collections.Generic;
using System.Linq;
namespace Open_closed_principle
{
    class HurtingOC
    {
        public enum Color
        {
            Red, Green, Yellow
        }

        public enum Size
        {
            Small, Medium, Large, Yuge
        }

        public class Product{
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
        
        public class ProductFilter
        {
                public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
                {
                    List<Product> filteredContent = new List<Product>();
                    foreach(var product in products)
                    {
                        if(product.Size == size)
                        {
                            yield return product;
                        }
                    }
                }
        }
        static void Main(string[] args)
        {
            
            Product apple = new Product("Apple", Size.Small, Color.Red);
            Product pineapple = new Product("Pineapple", Size.Large, Color.Yellow);
            Product grape = new Product("Grape", Size.Small, Color.Red);
            Product banana = new Product("Banana", Size.Medium, Color.Yellow);
            Product strawberry = new Product("Strawberry", Size.Medium, Color.Red);
            Product watermelon = new Product("Watermelon", Size.Yuge, Color.Green);

            Product[] produtos = { apple, pineapple, grape, banana, strawberry, watermelon };
            IEnumerable<Product> filterResult = produtos.Where(i => i.Color == Color.Green && i.Size == Size.Yuge);

            foreach(var i in filterResult)
            {
                Console.WriteLine(i.Name);
            }
            
            Console.WriteLine(produtos.GetEnumerator());
            
            var filter = new ProductFilter();
            var result = filter.FilterBySize(produtos, Size.Medium);

            foreach(var mediumProduct in result)
            {
                Console.WriteLine($"The product {mediumProduct.Name} has medium size!");
            }
            
        }
    }
}
