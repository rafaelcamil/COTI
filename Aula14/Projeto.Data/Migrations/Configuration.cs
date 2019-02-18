namespace Projeto.Data.Migrations
{
    using Projeto.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Projeto.Data.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Projeto.Data.Context.DataContext context)
        {
            context.Setor.AddOrUpdate(
                new Setor { IdSetor = 1, Nome = "Recursos Humanos" },
                new Setor { IdSetor = 2, Nome = "Comercial" },
                new Setor { IdSetor = 3, Nome = "Desenvolvimento de Sistemas" }
                );

            context.Funcao.AddOrUpdate(
                new Funcao { IdFuncao = 1, Nome = "Programador", Descricao = "Desenvolvedor de Sistemas" },
                new Funcao { IdFuncao = 2, Nome = "Analista", Descricao = "Analista de Sistemas" },
                new Funcao { IdFuncao = 3, Nome = "FrontEnd", Descricao = "Desenvolvedor FrontEnd" }
                );

        }
    }
}
