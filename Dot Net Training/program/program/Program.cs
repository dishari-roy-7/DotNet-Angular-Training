// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections;

namespace Inheritance
{
    class Program
    {
        public static void Main()
        {
            /*
            List<int> list = new List<int>() { 10, 20, 30, 40 };
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Add(40);
            
            for (int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            
            list.ForEach(i => Console.WriteLine(i));

            list.Remove(10);
            list.RemoveAt(2);
            list.ForEach(i=>Console.WriteLine(i));
            
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            
            list.ForEach(i => Console.WriteLine(i));
            
            ArrayList list=new ArrayList();
            list.Add(1);
            list.Add("This is a string");
            list.Add(3);
            list.Add(4.5F);
            //Access individual item using indexer
            int firstElement = (int)list[0];
            string secondElement = (string)list[1];
            int thirdElement = (int)list[2];
            float fourthElement= (float)list[3];
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            */
            SortedList list= new SortedList();
            list.Add(3, "Three");
            list.Add(4, "Four");
            list.Add(1, "One");
            list.Add(5, "Five");
            list.Add(2, "Two");

            foreach(DictionaryEntry x in list) 
            {
                Console.WriteLine(x.Value);
            }
        }
    }
}
