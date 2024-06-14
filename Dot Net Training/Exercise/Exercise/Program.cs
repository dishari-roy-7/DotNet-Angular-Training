// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace program
{
    class exercise
    {
        
        void push(ref List<int> list,int val)
        {
            list.Add(val);
        }
        void pop(ref List<int> list)
        {
            list.RemoveAt(list.Count - 1);
        }
        
        public static void Main(string[] args)
        {   
            //add, remove, print
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(50);
            
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Remove(50);
            list.RemoveAt(2);
            foreach(int i in list)
            {
                if (i == 10)
                {
                    Console.WriteLine("found");
                    break;
                }
            }
            

            //max and min
            int maxi=int.MinValue;   
            int mini=int.MaxValue;
            for(int i=0; i<list.Count; i++)
            {
                if (list[i] > maxi) maxi = list[i];
                if (list[i] < mini) mini = list[i];
            }
            Console.WriteLine(maxi);
            Console.WriteLine(mini);
            

            //reverse
            List<string> list = new List<string>() { "This", "is", "me" };
            for (int i = list.Count-1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
            

            //stack
            List<int> list = new List<int>();
            exercise ob = new exercise();
            ob.push(ref list, 1);
            ob.push(ref list, 2);
            ob.push(ref list, 3);
            ob.pop(ref list);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            

            //merge
            List<int> list1=new List<int>() { 90, 20, 30 };
            List<int> list2=new List<int>() { 80, 50, 30 };
            List<int> list3 = new List<int>();
            foreach(int i in list1)
            {
                list3.Add(i);
            }
            foreach (int i in list2)
            {
                if (!list3.Contains(i)) 
                 list3.Add(i);
            }
            list3.Sort();
            for(int i = 0; i < list3.Count; i++) { Console.WriteLine(list3[i]); }
            

            //frequency
            List<int> list = new List<int>() { 10, 20, 20, 10, 10, 20, 10, 30, 30, 30, 40, 40, 50 };
            Dictionary<int, int> dict= new Dictionary<int, int> ();
            foreach (int i in list)
            {
                if (dict.ContainsKey(i)) dict[i]++;
                else dict[i] = 1;
            }
            foreach(var i in dict)
            {
                Console.WriteLine(i.Key + "=" + i.Value);
            }
        }
    }
}
