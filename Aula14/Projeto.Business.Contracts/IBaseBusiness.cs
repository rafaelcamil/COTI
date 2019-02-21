using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Contracts
{
    //interface genérica para a camada de 
    //regras de negócio..
    public interface IBaseBusiness<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        void Cadastrar(TEntity entity);
        void Atualizar(TEntity entity);
        void Excluir(TKey entity);
        List<TEntity> ObterTodos();
        TEntity ObterPorId(TKey key);


    }
}

