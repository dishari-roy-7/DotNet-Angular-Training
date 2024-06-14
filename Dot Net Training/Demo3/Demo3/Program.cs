// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
namespace Inheritance
{
    class Animal
    {
        public Animal ()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void greet()
        {
            Console.WriteLine("Animal says hello");
        }
    }
    class Dog:Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }
        public void talk()
        {
            Console.WriteLine("Dog talk");
        }
    }
    class GermanShepard:Dog
    {
        public GermanShepard()
        {
            Console.WriteLine("German Shepard constructor");
        }
        public void talking()
        {
            Console.WriteLine("German Shepard talk");
        }
    }
    class Program 
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.greet();
            dog.talk();
            GermanShepard gs = new GermanShepard();
            gs.talk();
            gs.greet();
            gs.talking();
        }
    
    }
}
namespace Inheritance
{
    class Animal
    {
        public string name;
        public void display ()
        {
            Console.WriteLine("I am an animal");
        }
    }
    class Dog:Animal
    {
        public void getname()
        {
            Console.WriteLine("My name is "+name);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        
            Dog labrador = new Dog(); //derived class object
            labrador.name = "Rohu";  //access feild and method of base class
            labrador.display();
            labrador.getname();
        }
    }
}

namespace Inheritance
{
    class Department
    {
        public string Deptname, Deptloc;
        public Department()
        {
            Deptname = "";
            Deptloc = "";
        }
        public void GetdeptName()
        {
            Console.WriteLine("dept name: " + Deptname);
           // Console.ReadLine();
        }
        public void GetdeptLoc()
        {
            Console.WriteLine("dept loc: " + Deptloc);
        }
    }
    class Employee:Department
    {
        public void Getfn()
        {
            Console.WriteLine("Dishari");
        }
        public void Getln()
        {
            Console.WriteLine("Roy");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Deptname = "Consulting";
            emp.Deptloc = "Kolkata";
            emp.GetdeptName();
            emp.GetdeptLoc();
            emp.Getfn();
            emp.Getln();
        }
    }
}
*/
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        /*
        //square
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
           int x=Convert.ToInt32(Console.ReadLine());
            arr[i] = x;
        }
        for(int i=0; i<arr.Length; i++)
        {
            int sq = arr[i] * arr[i];
            arr[i]=sq;
            Console.WriteLine(arr[i]);
        }

        //reverse
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            arr[i] = x;
        }
        for(int i=0; i < arr.Length/2; i++)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[arr.Length - i-1];
            arr[arr.Length - i - 1] = temp;
        }
        for(int i=0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        

        //remove duplicates
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            arr[i] = x;
        }
        HashSet<int> set = new HashSet<int>();  
        for(int i = 0;i < arr.Length;i++)
        {
            set.Add(arr[i]);
        }
        foreach(int x in set)
        {
            Console.WriteLine(x);
        }
        */
    }
}
