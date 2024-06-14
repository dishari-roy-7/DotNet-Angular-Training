// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Linq;
using System.Collections.Generic;


namespace D20_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new AMAZONDBContext())
            {
                List<CustomerTbl> customer = context.CustomerTbl.ToList();
                foreach(var i in customer)
                {
                    Console.WriteLine(i.City);
                }
            }
        }
    }
}