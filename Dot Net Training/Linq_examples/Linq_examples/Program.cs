// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

namespace Linq_Practice
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; } //? accepts null value
        public int Age { get; set; }
    }
    class Program
    {
        /*
         //Method 1
        static void Main(string[] args)
        {
            Employee[] EmployeeArray =
            {
                new Employee() { EmployeeID = 1, EmployeeName="John", Age=18 },
                new Employee() { EmployeeID = 2, EmployeeName="Steve", Age =21 },
                new Employee() { EmployeeID = 3, EmployeeName="Bill", Age=25 },
                new Employee() { EmployeeID = 4, EmployeeName="Ram", Age=20 },
                new Employee() { EmployeeID = 5, EmployeeName="Ron", Age=31 },
                new Employee() { EmployeeID = 6, EmployeeName="Chris", Age=17 },
                new Employee() { EmployeeID = 7, EmployeeName="Rob", Age=19 },
            };
            Employee[] Employees = new Employee[10];
            int i = 0;
            foreach(Employee e in EmployeeArray)
            {
                if(e.Age>12 && e.Age<20)
                {
                    Employees[i] = e;
                    System.Console.WriteLine(e.EmployeeName);   
                    i++;
                }
            }
            Console.ReadLine();
        
        }
        */
        //Method 2
        static void Main(string[] args)
        {
            Employee[] EmployeeArray =
            {
                new Employee() { EmployeeID = 1, EmployeeName="John", Age=18 },
                new Employee() { EmployeeID = 2, EmployeeName="Steve", Age =21 },
                new Employee() { EmployeeID = 3, EmployeeName="Bill", Age=25 },
                new Employee() { EmployeeID = 4, EmployeeName="Ram", Age=20 },
                new Employee() { EmployeeID = 5, EmployeeName="Ron", Age=31 },
                new Employee() { EmployeeID = 6, EmployeeName="Chris", Age=17 },
                new Employee() { EmployeeID = 7, EmployeeName="Rob", Age=19 },
            };
            Employee[] teenageEmp = EmployeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            foreach (var emp in teenageEmp)
            {
                Console.WriteLine(emp.EmployeeName);
            }
            var SortedbyName = EmployeeArray.OrderBy(e => e.EmployeeName);
            foreach(var i in SortedbyName) Console.WriteLine(i.EmployeeName);
            var nameStartingWithR = EmployeeArray.Where(e => e.EmployeeName.StartsWith("R"));
            foreach (var i in nameStartingWithR) Console.WriteLine(i.EmployeeName);
            var oldest = EmployeeArray.OrderByDescending(e => e.Age).FirstOrDefault();
            Console.WriteLine(oldest.EmployeeName); 
            var averageAge=EmployeeArray.Average(e => e.Age); 
            Console.WriteLine(averageAge);
           
            Console.ReadLine();

        }
    }
}
