using Projeto.Business.Contracts;
using Projeto.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business
{
    public abstract class BaseBusiness<TEntity, TKey> : IBaseBusiness<TEntity, TKey>
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity, TKey> repository;

        protected BaseBusiness(IBaseRepository<TEntity, TKey> repository)
        {
            this.repository = repository;
        }

        public virtual void Cadastrar(TEntity entity)
        {
            repository.Add(entity);
            repository.SaveChanges();
        }

        public virtual void Atualizar(TEntity entity)
        {
            repository.SaveChanges();
        }

        public virtual void Excluir(TKey key)
        {
            var entity = ObterPorId(key);
            repository.Delete(entity);
            repository.SaveChanges();
        }

        public virtual List<TEntity> ObterTodos()
        {
            return repository.GetAll();
        }

        public virtual TEntity ObterPorId(TKey key)
        {
            return repository.GetById(key);
        }

        public virtual void Dispose()
        {
            repository.Dispose();
        }
    }
}
