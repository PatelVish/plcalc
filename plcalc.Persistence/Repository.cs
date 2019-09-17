using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using plcalc.Common.Entities;

namespace plcalc.Persistence
{
    public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class, IEntityBase
    {
        protected LiteDatabase DbContext;

        private LiteCollection<TEntity> entityDbSet { get; set; }

        public Repository(LiteDatabase context)
        {
            DbContext = context;
            entityDbSet = DbContext.GetCollection<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {

            return entityDbSet.FindAll();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            entityDbSet.Insert(entity);
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public TEntity Create()
        {
            throw new NotImplementedException();
        }

        #region Dispose

        private volatile bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DbContext?.Dispose();
                }

                DbContext = null;
                entityDbSet = null;
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
