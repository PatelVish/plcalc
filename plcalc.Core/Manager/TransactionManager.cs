using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using plcalc.Core.Dto;
using plcalc.DataAccess.Model;
using plcalc.Persistence;

namespace plcalc.Core.Manager
{
    public class TransactionManager
    {
        public bool AddNewTransaction(TransactionDto transaction)
        {
            using (var repo = RepositoryFactory.Get<Transaction>())
            {
                var tran = AutoMapperConfiguration.Instance.Map<Transaction>(transaction);
                repo.Insert(tran);
            }
            return false;
        }

        public IEnumerable<TransactionDto> GetTransactions()
        {
            using (var repo = RepositoryFactory.Get<Transaction>())
            {
                var res = repo.GetAll();
               return AutoMapperConfiguration.Instance.Map<IEnumerable<TransactionDto>>(res);
            }
        }

        public async Task<IEnumerable<PlReportDto>> GetPlReportData()
        {
            var marketPriceManager = new MarketPriceManager();
            var ret = new List<PlReportDto>();
            using (var repo = RepositoryFactory.Get<Transaction>())
            {
                var res = repo.GetAll().GroupBy(g => g.Ticker);
                foreach (var transactionGroup in res)
                {
                    var prevCloseData = await marketPriceManager.GetPrevCloseByTicker(transactionGroup.Key);
                    var latestData = await marketPriceManager.GetLatestRateByTicker(transactionGroup.Key);
                    var plDto = new PlReportDto
                    {
                        Ticker = transactionGroup.Key,
                        AsOfDate = DateTime.Now,
                        Cost = transactionGroup.Sum(t => t.Cost),
                        Quantity = transactionGroup.Sum(t => t.Quantity),
                        PrevClose = prevCloseData?.Price ?? 0,
                        Price = latestData?.Price ?? 0
                    };

                    plDto.MarketPrice = (latestData?.Price  ?? 0) * plDto.Quantity;
                    plDto.DailyPnL = ((latestData?.Price ?? 0) - (prevCloseData?.Price ?? 0)) * plDto.Quantity;
                    plDto.InceptionPnL = plDto.MarketPrice - plDto.Cost;
                    ret.Add(plDto);
                }
            }
            return ret;
        }
    }
}
