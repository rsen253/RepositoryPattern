using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Interface;

namespace Defination
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }
    }
}
