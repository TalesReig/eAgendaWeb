using eAgenda.Infra.Logging;
using eAgenda.Infra.Orm;
using eAgenda.WinApp.Compartilhado.Ioc;
using System;
using System.Windows.Forms;

namespace eAgenda.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MigradorBancoDadoseAgenda.AtualizarBancoDados();
            ConfiguracaoLogseAgenda.ConfigurarEscritaLogs();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipalForm(new ServiceLocatorAutofac()));

        }

    }
}
