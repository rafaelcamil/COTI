using Projeto.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Configuration
{
    public class FuncionarioConfiguration : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfiguration()
        {
            HasKey(f => new { f.IdFuncionario });

            Property(f => f.Nome)
                .HasMaxLength(100)
                .IsRequired();

            Property(f => f.Salario)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(f => f.DataAdmissao)
                .IsRequired();

            #region Mapeamento de Relacionamentos

            HasRequired(f => f.Setor)
                .WithMany(s => s.Funcionarios)
                .HasForeignKey(f => f.IdSetor)
                .WillCascadeOnDelete(false);

            HasRequired(f => f.Funcao)
            .WithMany(s => s.Funcionarios)
            .HasForeignKey(f => f.IdFuncao);


            #endregion
        }
    }
}
