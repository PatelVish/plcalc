using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using plcalc.Common.Entities;
using plcalc.DataAccess.Model;

namespace plcalc.Persistence
{
    public class RepositoryFactoryBase<TDbContext, TEntityBase> where TDbContext : LiteDatabase where TEntityBase : class, IEntityBase
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public static Repository<TEntity> Get<TEntity>()
            where TEntity : class, TEntityBase
        {
            Repository<TEntity> repo = new Repository<TEntity>(new LiteDatabase(@"plcalc.db")); 
            return repo;
        }
    }

    public class RepositoryFactory : RepositoryFactoryBase<LiteDatabase, ModelBase>
    {
    }
}
