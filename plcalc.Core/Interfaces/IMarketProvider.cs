using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plcalc.Core.Dto;

namespace plcalc.Core.Interfaces
{
    public interface IMarketProvider
    {
        Task<MarketPriceRes> GetDailyPrice(string ticker);
        Task<MarketPriceRes> GetPrevClose(string ticker);
        Task<MarketPriceRes> GetLatestPrice(string ticker);
    }
}
