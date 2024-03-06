using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetest2
{
    class Class1
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

           

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Product {i + 1} ID: ");
                int id;
                if (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Invalid ID provided.");
                    return;
                }

                Console.Write($"Product {i + 1} Name: ");
                string name = Console.ReadLine();

                Console.Write($"Product {i + 1} Price: ");
                double price;
                if (!double.TryParse(Console.ReadLine(), out price))
                {
                    Console.WriteLine("Invalid.........");
                    return;
                }
                products.Add(new Product(id, name, price));
            }

            Console.WriteLine("\nProducts sorted by price:");
            var sortedProducts = products.OrderBy(p => p.Price).ToList();
            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product);
                Console.Read();
            }
            Console.Read();
        }
    }

    class Product
    {
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price:C}";
            Console.Read();
        }
        
    }
}

