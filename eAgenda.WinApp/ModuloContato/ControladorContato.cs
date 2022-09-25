using eAgenda.Aplicacao.ModuloContato;
using eAgenda.Dominio.ModuloContato;
using eAgenda.WinApp.Compartilhado;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    internal class ControladorContato : ControladorBase
    {
        private readonly ServicoContato servicoContato;
        private TabelaContatosControl tabelaContatos;
        public ControladorContato(ServicoContato servicoContato)
        {
            this.servicoContato = servicoContato;
        }

        public override void Inserir()
        {
            TelaCadastroContatosForm tela = new TelaCadastroContatosForm();
            tela.Contato = new Contato();

            tela.GravarRegistro = servicoContato.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarContatos();
            }
        }

        public override void Editar()
        {
            Contato contatoSelecionado = ObtemContatoSelecionado();

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroContatosForm tela = new TelaCadastroContatosForm();

            tela.Contato = contatoSelecionado;

            tela.GravarRegistro = servicoContato.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarContatos();
            }
        }

        public override void Excluir()
        {
            Contato contatoSelecionado = ObtemContatoSelecionado();

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                servicoContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }

        public override void Agrupar()
        {
            TelaAgrupamentoContatoForm telaAgrupamento = new TelaAgrupamentoContatoForm();

            if (telaAgrupamento.ShowDialog() == DialogResult.OK)
            {
                tabelaContatos.AgruparContatos(telaAgrupamento.TipoAgrupamento);
            }
        }

        public override UserControl ObtemListagem()
        {
            //if (tabelaContatos == null)
            tabelaContatos = new TabelaContatosControl();

            CarregarContatos();

            return tabelaContatos;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxContato();
        }

        private Contato ObtemContatoSelecionado()
        {
            var numero = tabelaContatos.ObtemNumeroContatoSelecionado();

            return servicoContato.SelecionarPorId(numero).Value;
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = servicoContato.SelecionarTodos().Value;

            tabelaContatos.AtualizarRegistros(contatos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {contatos.Count} contato(s)");

        }
    }
}
