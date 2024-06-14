using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace DelegatePractice
{
    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
    internal class program
    {
        public static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { ProductID = 1, Name = "Apple", Category = "Fruits", Price = 1.00m },
                new Product() { ProductID = 2, Name = "Milk", Category = "Dairy", Price = 0.99m },
                new Product() { ProductID = 3, Name = "Cheese", Category = "Dairy", Price = 2.50m },
                new Product() { ProductID = 4, Name = "Banana", Category ="Fruits", Price=0.50m},
                new Product(){ ProductID = 5, Name="Yogurt", Category="Dairy", Price=1.50m }
            };

            //1
            List<Product> l1 = products.Where(s => s.Category == "Dairy").ToList();
            foreach (var i in l1) Console.WriteLine(i.Name);
            Console.WriteLine();

            //2
            List<Product> l2 = products.OrderBy(s => s.Price).ToList();
            foreach (var i in l2) Console.WriteLine(i.Name);
            Console.WriteLine();

            //3
            List<Product> l3 = products.OrderByDescending(s => s.Price).ToList();
            Console.WriteLine(l3[0].Name);
            Console.WriteLine();

            //4
            decimal sum = products.Where(s => s.Category == "Fruits").Sum(s => s.Price);
            Console.WriteLine(sum);
            Console.WriteLine();

            //5
            foreach (Product p in products) Console.WriteLine($"{p.Name}, ${p.Price}");
            Console.WriteLine();

            //6
            List<Product> l4 = products.OrderBy(s => s.Category).ToList();
            foreach (var i in l4) Console.WriteLine($"{i.Name}, {i.Category}");
            Console.WriteLine();

            //7
            List<Product> l5 = products.Where(s => s.Price < 1.00m).ToList();
            foreach(var i in l5) Console.WriteLine(i.Name);
            Console.WriteLine();
        }
    }
}
*/