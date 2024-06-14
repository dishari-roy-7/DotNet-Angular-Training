// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using ConsoleApp10;
using System;
using System.Collections.Generic;
using System.Linq;

namespace D20_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new NorthWindContext())
            {
                List<Customer> customers = context.Customers.ToList();
                foreach(var customer in customers)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
        }
    }
}
