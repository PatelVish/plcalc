using System;
using System.Collections.Generic;
using System.Text;
using AlphaVantage.Net.Core;

namespace plcalc.Core.Dto
{
    public class MarketPriceReq
    {
        public string Ticker { get; set; }
        public DateTime PriceDate { get; set; }

        public ApiFunction ApiFunction { get; set; }
        public bool getPreviousClose { get; set; }
    }
}
