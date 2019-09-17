using System.Threading.Tasks;

namespace plcalc.Common
{
    public abstract class HandlerBase<TReq, TRes>
    {
        public abstract Task<TRes> Execute(TReq request);
    }
}
