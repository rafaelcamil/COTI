using Projeto.Business.Contracts;
using Projeto.Data.Contracts;
using Projeto.Entities;
using System;
using System.Collections.Generic;

namespace Projeto.Business
{
    public class FuncionarioBusiness : BaseBusiness<Funcionario, int>, IFuncionarioBusiness
    {
        private readonly IUnitOfWork unitOfWork;

        public FuncionarioBusiness(IUnitOfWork unitOfWork)
            : base(unitOfWork.FuncionarioRepository)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Cadastrar(Funcionario funcionario, Setor setor, Funcao funcao)
        {
            unitOfWork.BeginTransaction();

            try
            {
                var setorOrigem = unitOfWork.SetorRepository.GetById(setor.IdSetor);
                if (setorOrigem == null)
                {
                    unitOfWork.SetorRepository.Add(setor);
                }

                var funcaoOrigem = unitOfWork.FuncaoRepository.GetById(funcao.IdFuncao);
                if (funcaoOrigem == null)
                {
                    unitOfWork.FuncaoRepository.Add(funcao);
                }

                funcionario.IdSetor = setor.IdSetor;
                funcionario.IdFuncao = funcao.IdFuncao;

                unitOfWork.FuncionarioRepository.Add(funcionario);
                unitOfWork.SaveChanges();

                unitOfWork.Commit();
            }
            catch (Exception)
            {
                unitOfWork.Rollback();
            }
            finally
            {
                unitOfWork.Dispose();
            }

        }

        public List<Funcionario> ConsultaPorNome(string nome)
        {
            return unitOfWork.FuncionarioRepository.GetAll(f => f.Nome.Contains(nome));
        }

        public List<Funcionario> ConsultaPorDataAdmisao(DateTime dataInicio, DateTime dataFim)
        {
            return unitOfWork.FuncionarioRepository
                .GetAll(f => f.DataAdmissao >= dataInicio && f.DataAdmissao <= dataFim);
        }
    }
}
