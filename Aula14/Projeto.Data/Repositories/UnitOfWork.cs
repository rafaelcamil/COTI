using Projeto.Data.Context;
using Projeto.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DataContext context;
        private DbContextTransaction transaction;

        public UnitOfWork(DataContext context)
        {
            this.context = context;
        }

        public void BeginTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public ISetorRepository SetorRepository => new SetorRepository(context);

        public IFuncaoRepository FuncaoRepository => new FuncaoRepository(context);

        public IFuncionarioRepository FuncionarioRepository => new FuncionarioRepository(context);

        public void Dispose()
        {
            context.Dispose();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
