using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockView.Models
{
    public class Script
    {
        public string Symbol { get; set; }
        public int Qty { get; set; }
        public int Rate { get; set; }
        public string PurchaseDate { get; set; }

    }
}
