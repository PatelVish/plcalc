using plcalc.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace plcalc.Persistence
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class, IEntityBase
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter);

        IEnumerable<TEntity> GetAll();

        void Insert(TEntity entity);

        void Delete(object id);

        void Update(TEntity entityToUpdate);

        TEntity Create();
    }
}
