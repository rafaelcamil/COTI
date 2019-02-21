using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Contracts
{
    public interface IFuncionarioBusiness : IBaseBusiness<Funcionario, int>
    {
        void Cadastrar(Funcionario funcionario, Setor setor, Funcao funcao);

        List<Funcionario> ConsultaPorNome(string nome);
        List<Funcionario> ConsultaPorDataAdmisao(DateTime dataInicio, DateTime dataFim);
    }
}
