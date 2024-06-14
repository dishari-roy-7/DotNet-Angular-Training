using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    abstract class absclass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public abstract int Mult(int x, int y);
    }
    class Derived:absclass
    {
        public override int Mult(int x, int y)
        {
            return x * y;
        }
    }
}
