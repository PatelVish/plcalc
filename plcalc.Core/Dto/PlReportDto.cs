using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plcalc.Core.Dto
{
    public class PlReportDto
    {
        public string Ticker { get; set; }
        public DateTime AsOfDate { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal MarketPrice { get; set; }
        public decimal PrevClose { get; set; }
        public decimal DailyPnL { get; set; }
        public decimal InceptionPnL { get; set; }
    }
}
