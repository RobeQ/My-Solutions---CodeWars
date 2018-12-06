using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public delegate int BinaryOp(int x, int y);

    class SimpleMath
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
    }
}
