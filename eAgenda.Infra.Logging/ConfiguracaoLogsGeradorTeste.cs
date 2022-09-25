using eAgenda.Infra.Configs;
using Serilog;

namespace eAgenda.Infra.Logging
{
    public class ConfiguracaoLogseAgenda
    {
        public static void ConfigurarEscritaLogs()
        {
            var config = new ConfiguracaoAplicacaoeAgenda();

            var diretorioSaida = config.ConfiguracaoLogs.DiretorioSaida;

            Log.Logger = new LoggerConfiguration()
                   .MinimumLevel.Debug()
                   .WriteTo.Debug()
                   .WriteTo.Seq("http://localhost:5341")
                   .WriteTo.File(diretorioSaida + "/log.txt", rollingInterval: RollingInterval.Day,
                            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
               .CreateLogger();
        }
    }
}
