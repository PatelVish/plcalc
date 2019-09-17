using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphaVantage.Net.Core;
using plcalc.Core.Dto;
using plcalc.Core.Handler;
using plcalc.Core.Interfaces;

namespace plcalc.Core.Provider
{
    public class AlphaVantageProvider : IMarketProvider
    {
        public Task<MarketPriceRes> GetDailyPrice(string ticker)
        {
            var handler = new MarketPriceHandler();
            return handler.Execute(new MarketPriceReq
            {
                PriceDate = DateTime.Now,
                Ticker = ticker,
                ApiFunction = ApiFunction.TIME_SERIES_DAILY
            });
        }

        public Task<MarketPriceRes> GetPrevClose(string ticker)
        {
            var handler = new MarketPriceHandler();
            return handler.Execute(new MarketPriceReq
            {
                PriceDate = DateTime.Now,
                Ticker = ticker,
                getPreviousClose = true,
                ApiFunction = ApiFunction.TIME_SERIES_DAILY
            });
        }

        public Task<MarketPriceRes> GetLatestPrice(string ticker)
        {
            var handler = new MarketPriceHandler();
            return handler.Execute(new MarketPriceReq
            {
                PriceDate = DateTime.Now,
                Ticker = ticker,
                ApiFunction = ApiFunction.TIME_SERIES_INTRADAY
            });
        }
    }
}
