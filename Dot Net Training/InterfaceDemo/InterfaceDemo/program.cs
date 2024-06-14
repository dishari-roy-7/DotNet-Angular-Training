using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class program
    {
        public static void Main()
        {
            /*
            Employee emp = new Employee();
            emp.GetFirstName();
            emp.GetLastName();
            
            Calculator ob=new Calculator();
            Console.WriteLine(ob.Sum(2, 4));
            Console.WriteLine(ob.Diff(2, 4));
            Console.WriteLine(ob.Mul(2, 4));
            Console.WriteLine(ob.Div(2, 4));
            
            Derived ob=new Derived();
            Console.WriteLine("Addition: {0}, Multiplication: {1}", ob.Add(2,9), ob.Mult(2,9));
            */
            Painting ob1=new Painting();
            Sculpture ob2=new Sculpture();
            
            ob1.Title = "Shrilayan";
            ob1.Artist = "God";
            ob1.YearCreated = 2000;
            ob2.Title = "Shrilayan";
            ob2.Artist = "God";
            ob2.YearCreated = 2000;
            ob1.CanvasSize = 20;
            ob2.material = "Gold";
            ob1.Describe();
            ob2.Describe();
        }  
    }
}
