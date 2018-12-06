using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    public class ZmianaOcenEventArgs : EventArgs
    {
        public int StaraOcena { get; set; }
        public int NowaOcena { get; set; }
    }
}
