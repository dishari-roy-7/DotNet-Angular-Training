using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class exercise
    {
        public static void Main(string[] args)
        {
            
            //add, remove, search
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            l.Add(6);
            l.Remove(5);
            int f=0;
            foreach(int i in l)
            {
                if (i == 6)
                {
                    f = 1;
                    Console.WriteLine("found");
                    break;
                }
            }
            if (f == 0)
                Console.WriteLine("not found");
            

            //queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            queue.Enqueue("e");
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            string str = "c";
            int f = 0;
            foreach (var item in queue)
            {
                if(str.Equals(item))
                {
                    f = 1;
                    Console.WriteLine(item + "found");
                }
            }
            if (f == 0) Console.WriteLine("not found");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            

            //stack
            Stack<double> stack = new Stack<double>();
            stack.Push(1.1);
            stack.Push(1.2);
            stack.Push(1.3);
            stack.Push(1.4);
            stack.Push(1.5);
            stack.Pop();
            Console.WriteLine(stack.Peek());
            double d = 2.6;
            int f = 0;
            foreach (var item in stack)
            {
                if (item==d)
                {
                    f = 1;
                    Console.WriteLine(item + "found");
                }
            }
            if (f == 0) Console.WriteLine("not found");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            

            //arraylist
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add(3.5);
            array.Add("hello");
            array.Add("world");
            array.Add(new DateTime());
            array.Add(3);
            array.RemoveAt(array.Count - 1);
            //array.Remove(1);
            int pos = -1;
            string x = "hello";
            for(int i = 0; i < array.Count; i++)
            {
                if (array[i]==x)
                {
                    pos = i;
                    break;
                }
               // pos++;
            }
            Console.WriteLine("hello is at: " + pos);
            int val1 = (int)array[0];
            int val2 = (int)array[1];
            double val3 = (double)array[2];
            string val4=(string)array[3];
            string val5=(string)array[4];
            DateTime val6=(DateTime)array[5];
            Console.WriteLine(val6);
            array.ToArray();
            for(int i=0; i< array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            int[] arr1=array.OfType<int>().ToArray();
            foreach(int i in arr1) Console.WriteLine(i);

            double[] arr4=array.OfType<double>().ToArray();
            foreach (double i in arr4) Console.WriteLine(i);

            string[] arr2=array.OfType<string>().ToArray();
            foreach(string s in arr2) Console.WriteLine(s);

            DateTime[] arr3=array.OfType<DateTime>().ToArray();
            foreach (DateTime s in arr3) Console.WriteLine(s);
        }
    }
}
