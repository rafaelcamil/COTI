using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Configuration
{
    public class FuncaoConfiguration : EntityTypeConfiguration<Funcao>
    {
        public FuncaoConfiguration()
        {
            HasKey(f => new { f.IdFuncao });

            Property(f => f.Nome)
                .HasMaxLength(100)
                .IsRequired();

            Property(f => f.Descricao)
                .HasMaxLength(1000)
                .IsRequired();
        }
    }
}
