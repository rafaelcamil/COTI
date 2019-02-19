using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Contracts
{
    public interface IBaseRepository<TEntity , TKey> : IDisposable
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void SaveChanges();

        List<TEntity> GetAll();
        List<TEntity> GetAll(Func<TEntity,bool> where );

        TEntity GetById(TKey key);
        TEntity Get(Func<TEntity, bool> where);

        int Count();
        int Count(Func<TEntity, bool> where);
    }
}
