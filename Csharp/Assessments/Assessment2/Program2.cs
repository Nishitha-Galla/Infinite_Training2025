using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{

    class Product : IComparable<Product>
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            ProductId = id;
            ProductName = name;
            Price = price;
        }
        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"ID: {ProductId}, Name: {ProductName}, Price: {Price} /-";
        }

    }

    class Program2
    {
        static void Main()
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Enter product details as: ID Name Price");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Product {i}: ");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                if(parts.Length != 3)
                {
                    Console.WriteLine("Invalid input, please enter: ID Name Price");
                    i--;
                    continue;
                }

                try
                {
                    int id = int.Parse(parts[0]);
                    string name = parts[1];
                    double price = double.Parse(parts[2]);

                    products.Add(new Product(id, name, price));
                }

                catch
                {
                    Console.WriteLine("Please ensure ID and price are numbers");
                    i--;
                }
            }

            Console.WriteLine("\n--------Product list before sorting--------");
            foreach(Product p in products)
                Console.WriteLine(p);

            products.Sort();

            Console.WriteLine("\n----------Product list after sorting----------");
            foreach(Product p in products)
                Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}