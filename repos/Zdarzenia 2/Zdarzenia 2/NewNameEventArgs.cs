﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia_2
{
    public class NewNameEventArgs : EventArgs
    {
        public string OldName { get; set; }
        public string NewName { get; set; }        
    }
}
