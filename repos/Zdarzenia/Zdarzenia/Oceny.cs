using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    class Oceny
    {
        public string Name = "Dziennik ocen";
        public event ZmianaOceny zmianaOceny;
        int _ocena = 5;
        public int NoweOceny
        {
            get
            {
                return _ocena;
            }
            set
            {
                if(value > 0 && value <= 6 && value != _ocena)
                {
                    ZmianaOcenEventArgs args = new ZmianaOcenEventArgs();
                    args.StaraOcena = _ocena;
                    args.NowaOcena = value;
                    zmianaOceny(this, args);
                    _ocena = value;
                }
            }
        }
    }
}
