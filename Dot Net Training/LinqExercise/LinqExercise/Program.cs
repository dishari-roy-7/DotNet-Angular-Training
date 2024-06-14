// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq_Exercise
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 8, 5, 6, 1, 4, 7, 3, 9, 10 };
            UsingLinq(arr);
        }
        private static void UsingLinq(int[] arr)
        {
            
            //1
            IEnumerable<int> query=from i in arr
                                   where i%2==0 select i;
            foreach (int i in query)
            {
                Console.WriteLine(i);
            }
            //2
            IEnumerable<int> query = from i in arr
                                     where i % 2 != 0 && i>5
                                     select i;
            foreach (int i in query)
            {
                Console.WriteLine(i);
            }
            
            //3
            List <int > list = arr .OrderBy(x=>x) .Select(x=>x).ToList();
            Console.WriteLine(list[2]);
            
            //4
            int sum = arr.Sum(x => x);
            Console.WriteLine(sum);
            
            //5
            int maxi = arr.Max(x => x);
            int mini=arr.Min(x => x);
            Console.WriteLine(maxi);
            Console.WriteLine(mini);    
            
            //6
            double avg = arr.Average(x => x);
            Console.WriteLine(avg);
            
            //7
            List<int> list = arr.Select(x=>x*x).ToList();
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("{0}, {1}", arr[i], list[i]);
            }
            
            //8
            IEnumerable<int> q=arr.Where(x=>x>3).OrderByDescending(x => x);
            foreach (int x in q)
            {
                Console.WriteLine(x);
            }
            
        }
    }
}
