using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancuchyBialkowe.Worker
{
    class Comparision
    {
        public bool changePossible(string s1, string s2)
        {
            char[] firstChain = s1.ToCharArray();
            char[] secondChain = s2.ToCharArray();

            Array.Sort(firstChain);
            Array.Sort(secondChain);

            string sortedFirstChain = new String(firstChain);
            string sortedSecondChain = new String(secondChain);

            if (sortedFirstChain.Equals(sortedSecondChain, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        }
    }
}
