// See https://aka.ms/new-console-template for more information
/*
class Program
{
    public static void Main()
    {
        //Console.WriteLine("Hello, World!");
        String name = "Roy";
        if (name == "Khan") Console.WriteLine("My name is Khan");
        else Console.WriteLine(name);
    }
}

class Program
{
    public static void Main()
    {
        int i = 10;
        if (i == 20) Console.WriteLine("i is 10");
        else if (i == 30) Console.WriteLine("i is 10");
        else if (i == 15) Console.WriteLine("i is 10");
        else Console.WriteLine("i is not present");
    }
}

//SWITCH CASE IS USED TO MAINTAIN EXECUTION CYCLES
class Program
{
    public static void Main()
    {
        int number = 10;
       switch(number)
        {
                case 10: Console.WriteLine("CASE 10"); 
                break;
                case 20: Console.WriteLine("CASE 20"); 
                break;
                case 30:
                Console.WriteLine("CASE 30");
                break;
                default: Console.WriteLine("NO MATCH");
                break;
        }
    }
}

class Program
{
    public static void Main()
    {
        int greeting = 2;
        switch (greeting)
        {
            case 1:
                Console.WriteLine("Hello");
                goto default;
            case 2:
                Console.WriteLine("Bonjour");
                goto case 3;
            case 3:
                Console.WriteLine("Namaste");
                goto default;
            default:
                Console.WriteLine("Entered value is:"+greeting);
                break;
        }
    }
}
*/
/*
class Program
{
    public static void Main()
    {
        /*
        int i=1;
        while(i<=4)
        {
            Console.WriteLine(i);
            i++;
        }
        
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        
        int[] arr=new int[20];
        int x = 0;
        for(int i=1; i<=20; i++)
        {
            arr[x++] = i;
        }
        for(int i=0; i<20; i++)
        {
            if (arr[i] % 2 == 0)
                Console.WriteLine(arr[i] + " is even");
            else
                Console.WriteLine(arr[i] + " is odd");
        }
        
        string str = "She sells sea shells on the sea shore.";
        int letter = 0, word=1;
        for (int i=0; i<str.Length; i++)
        {
            if ((str[i] >= 'A' && str[i]<='Z') || (str[i]>= 'a' && str[i]<='z')) letter++;
            if (str[i] == ' ') word++;
        }
        Console.WriteLine("No. of letters=" + letter);
        Console.WriteLine("No. of words=" + word);
        
        for(int i = 1; i <= 10; i++)
        {
            if (i == 3) //break;
               // continue;
            Console.WriteLine(i);
        }
       
    }
}

using Demo1;

class Program
{
    public static void Main()
    {
        /*
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int add = Addition(x, y);
        int sub = Subtract(x, y);
        int mul = Multiply(x, y);
        float div = Divide(x, y);

        Console.WriteLine(add);
        Console.WriteLine(sub);
        Console.WriteLine(mul);
        Console.WriteLine(div);
        
        Employee emp = new Employee();
        emp.printFirstName();
        emp.printLastName();
        
        Department dep=new Department();
        dep.getdeptname();
        dep.getdeptloc();
    }
    /*
    static int Addition(int a, int b)
    {
        return a + b;
    }
    static int Subtract(int a, int b)
    {
        if (a > b) return a - b;
        else return b - a;
    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static float Divide(int a, int b)
    {
        return (float) a / b;
    }
    
}
*/
//using Demo1;
class Program
{
    public static void Main()
    {
        Department dept= new Department();
        dept.getdeptloc();
        dept.getdeptname();
    }
}