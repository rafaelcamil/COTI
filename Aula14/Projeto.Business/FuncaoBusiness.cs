using Projeto.Business.Contracts;
using Projeto.Data.Contracts;
using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business
{
    public class FuncaoBusiness : BaseBusiness<Funcao, int>, IFuncaoBusiness
    {
        private readonly IUnitOfWork unitOfWork;

        public FuncaoBusiness(IUnitOfWork unitOfWork)
            : base(unitOfWork.FuncaoRepository)
        {
            this.unitOfWork = unitOfWork;
        }

    }
}
