// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1
namespace exercise
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meaow");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Animal ob= new Animal();
            Animal ob1 = new Dog();
            Animal ob2 = new Cat();
            ob.MakeSound();
            ob1.MakeSound();
            ob2.MakeSound();
        }
    }
}



using System.Drawing;


//2
class Rectangle
{
    public void CalculateArea (int l, int b)
    {
        Console.WriteLine(l * b);
    }
    public void CalculateArea(int a)
    {
        Console.WriteLine(a * a);
    }
    public static void Main()
    {
        Rectangle ob=new Rectangle();
        ob.CalculateArea(10, 9);
        ob.CalculateArea(10);
    }
}


//3
namespace sports
{
    class Car
    {
        public virtual void Brake()
        {
            Console.WriteLine("Generic brake applied");
        }
    }
    class SportsCar:Car
    {
        public override void Brake()
        {
            Console.WriteLine("High pergormance break applied");
        }
    }
    class program
    {
        public static void Main()
        {
            Car ob = new Car();
            Car ob1 = new SportsCar();
            ob.Brake();
            ob1.Brake();
        }
    }
}                                 