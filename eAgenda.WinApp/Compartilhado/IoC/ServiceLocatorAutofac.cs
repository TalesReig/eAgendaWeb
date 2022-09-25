using Autofac;
using eAgenda.Aplicacao.ModuloCompromisso;
using eAgenda.Aplicacao.ModuloContato;
using eAgenda.Aplicacao.ModuloDespesa;
using eAgenda.Aplicacao.ModuloTarefa;

using eAgenda.Dominio;
using eAgenda.Dominio.ModuloCompromisso;
using eAgenda.Dominio.ModuloContato;
using eAgenda.Dominio.ModuloDespesa;
using eAgenda.Dominio.ModuloTarefa;

using eAgenda.Infra.Configs;

using eAgenda.Infra.Orm;
using eAgenda.Infra.Orm.ModuloCompromisso;
using eAgenda.Infra.Orm.ModuloContato;
using eAgenda.Infra.Orm.ModuloDespesa;
using eAgenda.Infra.Orm.ModuloTarefa;

using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloDespesa;
using eAgenda.WinApp.ModuloTarefa;

namespace eAgenda.WinApp.Compartilhado.Ioc
{
    public class ServiceLocatorAutofac : IServiceLocator
    {
        private readonly IContainer container;

        public ServiceLocatorAutofac()
        {
            var builder = new ContainerBuilder();

            builder.Register((x) => new ConfiguracaoAplicacaoeAgenda().ConnectionStrings)
                .As<ConnectionStrings>()
                .SingleInstance(); //Singleton

            builder.RegisterType<ConfiguracaoAplicacaoeAgenda>()
                .SingleInstance(); //Singleton

            builder.RegisterType<eAgendaDbContext>().As<IContextoPersistencia>()
                .InstancePerLifetimeScope(); //Scoped

            builder.RegisterType<RepositorioTarefaOrm>().As<IRepositorioTarefa>();
            builder.RegisterType<ServicoTarefa>();
            builder.RegisterType<ControladorTarefa>(); //Transient

            builder.RegisterType<RepositorioContatoOrm>().As<IRepositorioContato>();
            builder.RegisterType<ServicoContato>();
            builder.RegisterType<ControladorContato>();

            builder.RegisterType<RepositorioCompromissoOrm>().As<IRepositorioCompromisso>();
            builder.RegisterType<ServicoCompromisso>();
            builder.RegisterType<ControladorCompromisso>();

            builder.RegisterType<RepositorioDespesaOrm>().As<IRepositorioDespesa>();
            builder.RegisterType<ServicoDespesa>();
            builder.RegisterType<ControladorDespesa>();

            builder.RegisterType<RepositorioCategoriaOrm>().As<IRepositorioCategoria>();
            builder.RegisterType<ServicoCategoria>();
            builder.RegisterType<ControladorCategoria>();

            container = builder.Build();
        }

        public T Get<T>() where T : ControladorBase
        {
            return container.Resolve<T>();
        }
    }
}
