using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IssuesWithNonGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleBoxUnboxOperation();
        }

        static void SimpleBoxUnboxOperation()
        {
            try
            {
                int myInt = 25;
                object boxedInt = myInt;
                long unboxingInt = (long)boxedInt;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
