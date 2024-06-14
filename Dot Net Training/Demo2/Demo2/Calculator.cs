using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int sub(int a, int b)
        {
            if (a > b) return a - b;
            else return b-a;
        }
        public float div(int a, int b)
        {
            if (b == 0) return -1;
            else return (float)a / b;
        }
    }
}