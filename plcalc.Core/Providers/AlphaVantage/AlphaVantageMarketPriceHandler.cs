using System;
using System.Linq;
using System.Threading.Tasks;
using AlphaVantage.Net.Core;
using AlphaVantage.Net.Stocks;
using AlphaVantage.Net.Stocks.TimeSeries;
using plcalc.Common;
using plcalc.Common.Exceptions;
using plcalc.Core.Dto;

namespace plcalc.Core.Handler
{
    public class MarketPriceHandler : HandlerBase<MarketPriceReq, MarketPriceRes>
    {
        public override async Task<MarketPriceRes> Execute(MarketPriceReq request)
        {
            try
            {
                string apiKey = plcalc.Common.Properties.Settings.Default.AlphaVantageApiKey; ; // enter your API key here
                var client = new AlphaVantageStocksClient(apiKey);
                StockTimeSeries timeSeries;
                StockDataPoint data = null;
                switch (request.ApiFunction)
                {
                    case ApiFunction.TIME_SERIES_DAILY:
                        timeSeries =
                            await client.RequestDailyTimeSeriesAsync(request.Ticker, TimeSeriesSize.Compact, adjusted: false);

                        if (request.getPreviousClose)
                        {
                            var prevDate = DateTime.Now.DayOfWeek == DayOfWeek.Monday
                                ? DateTime.Now.AddDays(-3).Date
                                : DateTime.Now.Date.AddDays(-1).Date;
                            data = timeSeries.DataPoints.OrderByDescending(a => a.Time)
                                .FirstOrDefault(a => a.Time.Date == prevDate);
                        }
                        else
                        {
                            data = timeSeries.DataPoints.OrderByDescending(a => a.Time).FirstOrDefault();
                        }

                        if (data == null) return null;

                        return new MarketPriceRes
                        {
                            Ticker = request.Ticker,
                            Date = data.Time,
                            Price = data.ClosingPrice
                        };
                    case ApiFunction.TIME_SERIES_INTRADAY:
                        timeSeries =
                            await client.RequestIntradayTimeSeriesAsync(request.Ticker, IntradayInterval.OneMin, TimeSeriesSize.Compact);
                        data = timeSeries.DataPoints.OrderByDescending(a => a.Time).FirstOrDefault();
                        if (data == null) return null;

                        return new MarketPriceRes
                        {
                            Ticker = request.Ticker,
                            Date = data.Time,
                            Price = data.ClosingPrice
                        };
                    default:
                        throw new plcalcException("Invalid apifunction");
                }
            }
            catch (Exception ex)
            {
                //log error
                return null;
            }
        }
    }
}
