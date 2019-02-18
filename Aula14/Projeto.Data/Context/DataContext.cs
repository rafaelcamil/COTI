using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Projeto.Entities;
using System.Configuration;
using Projeto.Data.Configuration;

namespace Projeto.Data.Context
{
    public class DataContext : DbContext
    {
        //construtor
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["projeto"].ConnectionString)
        {

        }

        //para configurar o repositório, precisamos sobrescrever
        //o método OnModelConfiguration
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //definir preferencias do EntityFramemork
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //adicionar as classe de mapeamento
            modelBuilder.Configurations.Add(new SetorConfiguration());
            modelBuilder.Configurations.Add(new FuncaoConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
    }

        //declarar uma propriedade DbSet para cada classe mapeada
            public DbSet<Setor> Setor { get; set; }
            public DbSet<Funcao> Funcao { get; set; }
            public DbSet<Funcionario> Funcionario { get; set; }

    }
}
