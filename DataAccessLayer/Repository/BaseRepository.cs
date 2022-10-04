using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        ProductFindingAutomationContext _surveyContext;
        internal BaseRepository(ProductFindingAutomationContext surveySiteContext)
        {
            _surveyContext = surveySiteContext;
        }
        public void Add(TEntity item)
        {
            _surveyContext.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Added;
        }

        public void Remove(TEntity item)
        {
            _surveyContext.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Deleted;
        }

        public void Update(TEntity item)
        {
            _surveyContext.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Modified;
        }

        public TEntity Get(int id)
        {
            return _surveyContext.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return _surveyContext.Set<TEntity>().ToList();
        }
    }
}
