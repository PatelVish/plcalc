using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using plcalc.Common.Enums;
using plcalc.DataAccess.Model;

namespace plcalc.Core.Dto
{
    [AutoMap(typeof(Transaction))]
    public class TransactionDto
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public DateTime TradeDate { get; set; }
        public TradeAction Action { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal Cost => Quantity * Price;
    }
}
