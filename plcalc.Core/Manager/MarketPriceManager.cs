using System.Threading.Tasks;
using plcalc.Core.Dto;
using plcalc.Core.Interfaces;
using plcalc.Core.Provider;

namespace plcalc.Core.Manager
{
    public class MarketPriceManager
    {
        public Task<MarketPriceRes> GetLatestRateByTicker(string ticker)
        {
            var provider = MarketPriceProviderBroker.GetMarketProvider();
            return provider.GetLatestPrice(ticker);
        }

        public Task<MarketPriceRes> GetPrevCloseByTicker(string ticker)
        {
            var provider = MarketPriceProviderBroker.GetMarketProvider();
            return provider.GetPrevClose(ticker);
        }
    }

    public class MarketPriceProviderBroker
    {
        public static IMarketProvider GetMarketProvider()
        {
            return new AlphaVantageProvider();
        }
    }
}
