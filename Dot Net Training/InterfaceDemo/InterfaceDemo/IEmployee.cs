using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IEmployee
    {
        public void GetFirstName();
        public void GetLastName();
        
    }
    public class Employee : IEmployee
    {
        public void GetFirstName()
        {
            Console.WriteLine("Dishari");
        }
        public void GetLastName()
        {
            Console.WriteLine("Roy");
        }
    }
}
