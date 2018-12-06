using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name();

            name.newName += Test1;

            name.MyName = "Robert";

            name.MyName = "Marcel";

        }

        private static void Test1(object sender, NewNameEventArgs args)
        {
            Console.WriteLine($"Stare imię to {args.OldName}, a nowe imię to {args.NewName}");
        }
    }
}
