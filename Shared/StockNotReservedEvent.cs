﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class StockNotReservedEvent
    {
        public int OrderID { get; set; }
        public string Message { get; set; }
    }
}
