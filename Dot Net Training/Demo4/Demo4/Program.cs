// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using System.ComponentModel;
/*
class program
{
    public int Add(int a, int b) 
    {
        return a + b;
    }
    public int Add(int a , int b, int c)
    {
        return a + b + c;
    }
    public double Add(double a, double b, double c)
    {
        return a + b + c;
    }
    public int Mul(int a, int b)
    {
        return a * b;
    }
    public int Mul(int a, int b, int c)
    {
        return a * b * c;
    }
    public double Mul(double a, double b, double c)
    {
        return a * b * c;
    }
    public int Sub(int a, int b)
    {
        return a - b;
    }
    public int Sub(int a, int b, int c)
    {
        return a - b - c;
    }
    public double Sub(double a, double b, double c)
    {
        return a - b - c;
    }
    public int Div(int a, int b)
    {
        return a / b;
    }
    public double Div(double a , double b)
    {
        return a / b;
    }
    public static void Main(string[] args)
    {
        program ob = new program();
        Console.WriteLine(ob.Add(2, 3));
        Console.WriteLine(ob.Add(4, 5, 6));
        Console.WriteLine(ob.Add(4.9, 8.6, 7.2));
        Console.WriteLine(ob.Mul(2, 3));
        Console.WriteLine(ob.Mul(4, 5, 6));
        Console.WriteLine(ob.Mul(4.9, 8.6, 7.2));
        Console.WriteLine(ob.Sub(2, 3));
        Console.WriteLine(ob.Sub(4, 5, 6));
        Console.WriteLine(ob.Sub(4.9, 8.6, 7.2));
        Console.WriteLine(ob.Div(2, 3));
        Console.WriteLine(ob.Div(4.9, 5.6));
    }
}
*/
class StringFormatter
{
    public void Format(string str)
    {
        str.ToUpper();
        Console.WriteLine(str);
    }
    public void Format(string str, int n)
    {
        string strnew = "";
        for(int i=1; i<=n; i++) 
        {
            strnew = strnew+ str;
        }
        Console.WriteLine(strnew);
    }
    public void Format(string str1, string str2)
    {
        string newstr= "";
        newstr= str1 + " " + str2;
        Console.WriteLine(newstr);
    }
    public static void Main(string[] args)
    {
        StringFormatter ob=new StringFormatter();
        ob.Format("hello");
        ob.Format("hello", 3);
        ob.Format("hello", "world");
    }
}