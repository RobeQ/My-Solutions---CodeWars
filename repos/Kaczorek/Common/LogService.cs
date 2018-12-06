using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LogService
    {
        public static void SaveToFile(List<ILog> changedElements)
        {
            foreach (var element in changedElements)
            {
                Console.WriteLine(element.Log());
            }
        }
    }
}
