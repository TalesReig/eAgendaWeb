using eAgenda.Infra.Configs;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eAgenda.Infra.Orm
{
    public static class MigradorBancoDadoseAgenda
    {
        public static void AtualizarBancoDados()
        {
            var config = new ConfiguracaoAplicacaoeAgenda();

            var db = new eAgendaDbContext(config.ConnectionStrings);

            var migracoesPendentes = db.Database.GetPendingMigrations();

            if (migracoesPendentes.Count() > 0)
                db.Database.Migrate();
        }
    }
}
