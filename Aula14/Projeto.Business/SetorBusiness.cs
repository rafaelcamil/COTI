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
    public class SetorBusiness : BaseBusiness<Setor, int> , ISetorBusiness
    {
        private readonly IUnitOfWork unitOfWork;

        public SetorBusiness(IUnitOfWork unitOfWork)
            : base(unitOfWork.SetorRepository)
        {
            this.unitOfWork = unitOfWork;
        }

    }
}
