﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class StockReservedEvent
    {
        public int OrderID { get; set; }
        public string BuyerID { get; set; }
        public PaymentMesagge Payment { get; set; }

        public List<OrderItemMessage> OrderItems { get; set; } = new List<OrderItemMessage>();

    }
}
