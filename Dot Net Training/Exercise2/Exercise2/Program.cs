// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace exercise2
{
    class program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = Enumerable.Range(1, 1000).Select(_ => random.Next(1, 1001)).ToArray(); 

            //Task 1
            double avg=numbers.Average();
            Console.WriteLine("Average= "+avg);
            Console.WriteLine();

            //Task 2
            int maxi = numbers.Max();
            Console.WriteLine("Maximum= "+maxi);
            Console.WriteLine();

            //Task 3
            int mini = numbers.Min();
            Console.WriteLine("Minimum= "+mini);
            Console.WriteLine();

            //Task 4
            int c = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine(c);
            Console.WriteLine();

            //Task 5
            int s = numbers.Where(x => x % 2 == 1).Sum();
            Console.WriteLine("Sum= "+s);
            Console.WriteLine();

            //Task 6
            List<int> list = numbers.OrderByDescending(x => x).Take(10).ToList();
            foreach (int x in list) Console.WriteLine(x);
            Console.WriteLine();

            //Task 7
            List<int> l = numbers.Distinct().ToList();
            foreach (int x in list) Console.WriteLine(x);
            Console.WriteLine();

            //Task 8
            var res = from n in numbers
                      group n by n % 2==0 into g
                      select new
                      {
                          Title = g.Key ? "Even" : "Odd",
                          Value = g.Count(x => g.Key ? x % 2 == 0 : x % 2 != 0),
                          Number = g
                      };
            foreach(var x in res)
            {
                Console.WriteLine($"{x.Title} = {x.Value}");
                foreach (var y in x.Number) Console.WriteLine(y);
            }
            Console.WriteLine();
              
            //Task 9
            List<int> ll= numbers.OrderBy(x=>x).ToList();
            int mid = ll.Count() / 2;
            int median = (ll[mid / 2] + ll[mid / 2 + 1]) / 2;
            Console.WriteLine("Median= "+median);
            Console.WriteLine();

            //Task 10
            int sum2 = numbers.Where(x => x > 500).Sum();
            Console.WriteLine("Sum > 500 = " + sum2);
        }
    }
}
