using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        void SaveChanges();

        ISetorRepository SetorRepository { get; }
        IFuncaoRepository FuncaoRepository { get; }
        IFuncionarioRepository FuncionarioRepository { get; }
    }
}
