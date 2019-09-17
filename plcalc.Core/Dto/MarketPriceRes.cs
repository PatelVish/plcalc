using System;
using System.Collections.Generic;
using System.Text;

namespace plcalc.Core.Dto
{
    public class MarketPriceRes
    {
        public string Ticker { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
