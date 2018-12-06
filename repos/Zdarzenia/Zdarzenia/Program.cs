using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Oceny oceny = new Oceny();

            oceny.zmianaOceny += OnZmianaOceny;
            oceny.zmianaOceny += OnZmianaOceny2;
            oceny.zmianaOceny += OnZmianaOceny3;
            oceny.zmianaOceny += OnZmianaOcen4;

            Console.WriteLine(oceny.NoweOceny);
            oceny.NoweOceny = 1;
            oceny.NoweOceny = 5;
            Console.WriteLine(oceny.NoweOceny);
        }

        private static void OnZmianaOcen4(object sender, ZmianaOcenEventArgs args)
        {
            Console.WriteLine("+++++++++++++++");
        }

        private static void OnZmianaOceny3(object sender, ZmianaOcenEventArgs args)
        {
            Console.WriteLine("()()()()()()()()");
        }

        private static void OnZmianaOceny2(object sender, ZmianaOcenEventArgs args)
        {
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@");
        }

        private static void OnZmianaOceny(object sender, ZmianaOcenEventArgs args)
        {
            Console.WriteLine($"Stara ocena: {args.StaraOcena}, nowa ocena: {args.NowaOcena}");
        }
    }
}
