using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plcalc.DataAccess.Model
{
    public class Transaction : ModelBase
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public DateTime TradeDate { get; set; }
        public int Action { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
    }
}
