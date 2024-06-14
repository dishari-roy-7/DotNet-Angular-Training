// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Demo2;

class Program
{
    public static void Main()
    {   /*
        Console.WriteLine("Enter number 1:");
        int a=Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Enter number 2:");
        int b=Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("What operation would you perform? \n 1. Add\n 2. Subtract\n 3. Multiply\n 4. Divide\n");
        Console.WriteLine("Enter choice:");
        int choice=Convert.ToInt32 (Console.ReadLine());
        Calculator calc=new Calculator(); ;
        switch (choice)
        {
            case 1:
                int sum = calc.add(a, b);
                Console.WriteLine("Sum=" + sum);
                break;
            case 2:
                int diff = calc.sub(a, b);
                Console.WriteLine("Difference=" + diff);
                break;
            case 3:
                int pro = calc.mul(a, b);
                Console.WriteLine("Product=" + pro);
                break;
            case 4:
                float quo = calc.div(a, b);
                if (quo == -1) Console.WriteLine("Division not possible");
                else Console.WriteLine("Quotient=" + quo);
                break;
            default: Console.WriteLine("Wroing choice.");
                break;
        } 
        
        //reverse a string
        string str = Console.ReadLine();
        for(int i = str.Length-1; i>=0; i--)
        {
            Console.Write(str[i]);
        }
        
        //FN and LN
        string str=Console.ReadLine();
        str = str + ' ';
        string s = "";
        string temp = "";
        for(int i = 0; i<str.Length; i++)
        {
            if (str[i] != ' ')
            {
                temp = temp + str[i];
            }
            else
            {
                s = temp + ' '+ s;
                temp = "";
            }
        }
        Console.WriteLine(s);
        
        //Palindrome
        string str=Console.ReadLine();
        int f = 0;
        for(int i=0; i<str.Length; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                f = 1;
                break;
            }
        }
        if (f == 0) Console.WriteLine("Palindrome");
        else Console.WriteLine("Not Palindrome");
        
        //Proper phone number
        string str=Console.ReadLine();
        string final=str.Substring(0,3)+' '+str.Substring(3);
        Console.WriteLine(final);
       
        //table
        Console.WriteLine("Enter a number");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Table of "+n);
        for(int i = 1; i <= 10; i++)
        {
            int t = n * i;
            Console.WriteLine(n+"*"+i+"="+t);
        }
        */
    }
}
