using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Configuration
{
    public class SetorConfiguration : EntityTypeConfiguration<Setor>
    {
        public SetorConfiguration()
        {

                HasKey(f => new { f.IdSetor });

                Property(f => f.Nome)
                    .HasMaxLength(100)
                    .IsRequired();

        }
    }
}
