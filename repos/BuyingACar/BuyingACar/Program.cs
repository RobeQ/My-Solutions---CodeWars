using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingACar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabela = BuyingCar.nbMonths(2000, 8000, 1000, 1.5);
            Console.WriteLine("Miesięcy: " + tabela[0] + ", oszczędności: " + tabela[1]);           
        }
    }
}
