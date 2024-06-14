using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface ICalculator
    {
        public int Sum(int x, int y);
        public int Diff(int x, int y);
        public int Mul(int x, int y);
        public int Div(int x, int y);
    }
    public class Calculator:ICalculator
    {
        public int Sum(int x, int y)
        {
            return x+y;
        }
        public int Diff(int x, int y)
        {
            return x-y;
        }
        public int Mul(int x, int y)
        {
            return x*y;
        }
        public int Div(int x, int y)
        {
            return x/y;
        }
    }
}
