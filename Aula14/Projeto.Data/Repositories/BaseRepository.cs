using Projeto.Data.Context;
using Projeto.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories
{
    public abstract class BaseRepository<TEntity , TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : class
    {
        private readonly DataContext context;

        protected BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public virtual void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public virtual List<TEntity> GetAll(Func<TEntity, bool> where)
        {
            return context.Set<TEntity>().Where(where).ToList();
        }

        public virtual TEntity GetById(TKey key)
        {
            return context.Set<TEntity>().Find(key);
        }

        public virtual TEntity Get(Func<TEntity, bool> where)
        {
            return context.Set<TEntity>().SingleOrDefault(where);
        }

        public virtual int Count()
        {
            return context.Set<TEntity>().Count();
        }

        public virtual int Count(Func<TEntity, bool> where)
        {
            return context.Set<TEntity>().Count(where);
        }

        public virtual void Dispose()
        {
            context.Dispose();
        }
    }
}
