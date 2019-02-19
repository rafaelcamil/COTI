using Projeto.Data.Context;
using Projeto.Data.Contracts;
using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories
{
    public class SetorRepository : BaseRepository<Setor, int>, ISetorRepository
    {
        private readonly DataContext context;

        public SetorRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

    }
}
