using eAgenda.Infra.Configs;
using eAgenda.Infra.Orm;
using Microsoft.EntityFrameworkCore.Design;

namespace GeradorTestes.Infra.Orm
{
    public class eAgendaDbContextFactory : IDesignTimeDbContextFactory<eAgendaDbContext>
    {
        public eAgendaDbContext CreateDbContext(string[] args)
        {
            var config = new ConfiguracaoAplicacaoeAgenda();

            return new eAgendaDbContext(config.ConnectionStrings);
        }
    }
}
