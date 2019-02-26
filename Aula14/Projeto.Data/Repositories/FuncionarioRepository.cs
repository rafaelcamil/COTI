using Projeto.Data.Context;
using Projeto.Data.Contracts;
using Projeto.Entities;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories
{
    public class FuncionarioRepository  : BaseRepository<Funcionario, int>, IFuncionarioRepository
    {
        private readonly DataContext context;

        public FuncionarioRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
        public override List<Funcionario> GetAll()
        {
            return context.Funcionario
                .Include(f => f.Setor)
                .Include(f => f.Funcao)
                .ToList();
        }

        public override List<Funcionario> GetAll(Func<Funcionario, bool> where)
        {
            return context.Funcionario
                .Include(f => f.Setor)
                .Include(f => f.Funcao)
                .Where(where)
                .ToList();
        }

        public override Funcionario GetById(int key)
        {
            return context.Funcionario
                .Include(f => f.Setor)
                .Include(f => f.Funcao)
                .SingleOrDefault(f => f.IdFuncionario == key);
        }
        public override Funcionario Get(Func<Funcionario, bool> where)
        {
            return context.Funcionario
                .Include(f => f.Setor)
                .Include(f => f.Funcao)
                .SingleOrDefault(where);
        }
    }
}
