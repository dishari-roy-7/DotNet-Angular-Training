// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace Linq_Practice_Delegate
{
    /*
    delegate void CustomDel(string s);
    class TestClass
    {
        static void Hello(string s)
        {
            Console.WriteLine($"Hello, {s}");
        }
        static void Bye(string s)
        {
            Console.WriteLine($"Bye, {s}");
        }
        static void Main()
        {
            CustomDel hiDel, byeDel, multiDel, multiMinusDel;
            hiDel = Hello;
            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("Dishari");
            //hiDel = Bye;
            byeDel = Bye;
            Console.WriteLine("Invoking delegate hiDel:"); 
            //hiDel("Dishari");
            byeDel("Dishari");
            //Console.Read();
            multiDel = hiDel + byeDel;
            Console.WriteLine("Invoking Delegate Multidel:");
            multiDel("Dishari");
            multiMinusDel = multiDel-hiDel;
            Console.WriteLine("Invoking Delegate MultiMinusdel:");
            multiMinusDel("Dishari");

        }
    }
    

    public delegate void Operation(int n);
    public class MathOperations
    {
        public static void AddTen(int num)
        {
            Console.WriteLine($"{num}+10={num + 10}");
        }
        public static void MultiplyByTwo(int num)
        {
            Console.WriteLine($"{num}*2={num * 2}");
        }
        public static void subtractFive(int num)
        {
            Console.WriteLine($"{num}-5={num - 5}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation(MathOperations.AddTen);
            op += MathOperations.MultiplyByTwo;
            op += MathOperations.subtractFive;
            Console.WriteLine("Invoking delegate with number 5:");
            op(5);
        }
    }
    

    public delegate void StatusUpdateHandler(string status);
    public class Service
    {
        public static void LoggingService(string status)
        {
            Console.WriteLine($"Logging Service {status} successful.");
        }
        public static void NotificationService(string status)
        {
            Console.WriteLine($"Notification Service {status} successful.");
        }
        public static void AuditService(string status)
        {
            Console.WriteLine($"Audit Service {status} successful.");
        }
    }
    class Program
    {
        public static void Main()
        {
            StatusUpdateHandler ob = new StatusUpdateHandler(Service.LoggingService);
            ob += Service.NotificationService;
            ob += Service.AuditService;
            Console.WriteLine("Invoking Delegate:");
            ob("internet");
        }       
    }
   
    class Function
    {
        /*
        static int Sum(int x, int y)
        {
            return x + y;
        }
        
        
        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;
            int result = add(10, 10);
            Console.WriteLine(result);
            
        }
    }
        */
    class Action
    {
        public static void Main()
        {
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);
        }
        public static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
    }
}
