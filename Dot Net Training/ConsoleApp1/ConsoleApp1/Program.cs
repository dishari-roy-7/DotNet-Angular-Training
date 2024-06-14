// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AmazondbContext())
            {
                Console.WriteLine("Products Table");
                List<ProductsTbl> products=context.ProductsTbls.ToList();
                foreach(var i in products)
                {
                    Console.WriteLine($"Product Name: {i.ProductName}, Product Price: {i.Price}");
                }
            }
        }
    }
}