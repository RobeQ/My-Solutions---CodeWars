using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia_2
{
    class Name
    {
        public string Names(string name, string name2)
        {
            return name + "  " + name2;
        }

        public event NewName newName;
        string _myName = "Andrzej";
        public string MyName
        {
            get
            {
                return _myName;
            }
            set
            {
                if (value != _myName)
                {
                    NewNameEventArgs args = new NewNameEventArgs();
                    args.OldName = _myName;
                    args.NewName = value;
                    newName(this, args);
                    _myName = value;
                }
            }
        }
    }
}
