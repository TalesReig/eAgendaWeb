using eAgenda.Aplicacao.ModuloCompromisso;
using eAgenda.Dominio.ModuloCompromisso;
using eAgenda.Dominio.ModuloContato;
using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private readonly ServicoCompromisso servicoCompromisso;
        private readonly IRepositorioContato repositorioContato;

        private TabelaCompromissosControl tabelaCompromissos;

        public ControladorCompromisso(ServicoCompromisso servicoCompromisso, IRepositorioContato repositorioContato)
        {
            this.servicoCompromisso = servicoCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override void Inserir()
        {
            var contatos = repositorioContato.SelecionarTodos();

            TelaCadastroCompromissosForm tela = new TelaCadastroCompromissosForm(contatos);
            tela.Compromisso = new Compromisso();

            tela.GravarRegistro = servicoCompromisso.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarCompromissos();
            }
        }

        public override void Editar()
        {
            Compromisso compromissoSelecionado = ObtemCompromissoSelecionado();

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var contatos = repositorioContato.SelecionarTodos();

            TelaCadastroCompromissosForm tela = new TelaCadastroCompromissosForm(contatos);

            tela.Compromisso = compromissoSelecionado;

            tela.GravarRegistro = servicoCompromisso.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {
            Compromisso compromissoSelecionado = ObtemCompromissoSelecionado();

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Exclusão de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a compromisso?",
                "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                servicoCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissos();
            }
        }

        public override void Filtrar()
        {
            TelaFiltroCompromissosForm telaFiltro = new TelaFiltroCompromissosForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                var statusSelecionado = telaFiltro.StatusSelecionado;
                var dataInicial = telaFiltro.DataInicial.Date;
                var dataFinal = telaFiltro.DataFinal.Date;

                CarregarCompromissosComFiltro(statusSelecionado, dataInicial, dataFinal);
            }
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaCompromissos == null)
                tabelaCompromissos = new TabelaCompromissosControl();

            CarregarCompromissos();

            return tabelaCompromissos;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxCompromisso();
        }

        private Compromisso ObtemCompromissoSelecionado()
        {
            var numero = tabelaCompromissos.ObtemNumeroCompromissoSelecionado();

            return servicoCompromisso.SelecionarPorId(numero).Value;
        }

        private void CarregarCompromissosComFiltro(StatusCompromissoEnum statusSelecionado, DateTime dataInicial, DateTime dataFinal)
        {
            string tipoCompromisso;
            List<Compromisso> compromissos;

            switch (statusSelecionado)
            {
                case StatusCompromissoEnum.Futuros:
                    compromissos = servicoCompromisso.SelecionarCompromissosFuturos(dataInicial, dataFinal).Value;
                    tipoCompromisso = "futuro(s)";
                    break;

                case StatusCompromissoEnum.Passados:
                    compromissos = servicoCompromisso.SelecionarCompromissosPassados(DateTime.Now).Value;
                    tipoCompromisso = "passado(s)";
                    break;

                default:
                    compromissos = servicoCompromisso.SelecionarTodos().Value;
                    tipoCompromisso = ""; break;
            }

            tabelaCompromissos.AtualizarRegistros(compromissos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count} compromisso(s) {tipoCompromisso}");
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = servicoCompromisso.SelecionarTodos().Value;

            tabelaCompromissos.AtualizarRegistros(compromissos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count} compromisso(s)");
        }
    }
}
