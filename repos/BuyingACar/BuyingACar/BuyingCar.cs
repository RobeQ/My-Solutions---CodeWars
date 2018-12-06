using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingACar
{
    class BuyingCar
    {
        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingperMonth, double percentLossByMonth)
        {
            int howManyMonths = 0;

            double savedMoney = startPriceOld;
            double priceOfOldCar = startPriceOld;
            double priceOfNewCar = startPriceNew;
            while (savedMoney < priceOfNewCar)
            {
                howManyMonths++;
                if (howManyMonths % 2 == 0) percentLossByMonth += 0.5;
                priceOfOldCar -= (priceOfOldCar * (percentLossByMonth / 100));
                priceOfNewCar -= (priceOfNewCar * (percentLossByMonth / 100));
                savedMoney = (howManyMonths * savingperMonth) + priceOfOldCar;
            }

            return new int[] { howManyMonths, (int)Math.Round(savedMoney - priceOfNewCar) };
        }
    }
}
