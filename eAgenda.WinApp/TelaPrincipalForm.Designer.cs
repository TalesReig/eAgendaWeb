﻿namespace eAgenda.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compromissosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbox = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAtualizarItens = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVisualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgrupar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(929, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarefasMenuItem,
            this.contatosMenuItem,
            this.compromissosMenuItem,
            this.despesasSubMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // tarefasMenuItem
            // 
            this.tarefasMenuItem.Name = "tarefasMenuItem";
            this.tarefasMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tarefasMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tarefasMenuItem.Text = "Tarefas";
            this.tarefasMenuItem.Click += new System.EventHandler(this.tarefasMenuItem_Click);
            // 
            // contatosMenuItem
            // 
            this.contatosMenuItem.Name = "contatosMenuItem";
            this.contatosMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.contatosMenuItem.Size = new System.Drawing.Size(173, 22);
            this.contatosMenuItem.Text = "Contatos";
            this.contatosMenuItem.Click += new System.EventHandler(this.contatosMenuItem_Click);
            // 
            // compromissosMenuItem
            // 
            this.compromissosMenuItem.Name = "compromissosMenuItem";
            this.compromissosMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.compromissosMenuItem.Size = new System.Drawing.Size(173, 22);
            this.compromissosMenuItem.Text = "Compromissos";
            this.compromissosMenuItem.Click += new System.EventHandler(this.compromissosMenuItem_Click);
            // 
            // despesasSubMenuItem
            // 
            this.despesasSubMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despesasMenuItem,
            this.categoriasMenuItem});
            this.despesasSubMenuItem.Name = "despesasSubMenuItem";
            this.despesasSubMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.despesasSubMenuItem.Size = new System.Drawing.Size(173, 22);
            this.despesasSubMenuItem.Text = "Despesas";
            // 
            // despesasMenuItem
            // 
            this.despesasMenuItem.Name = "despesasMenuItem";
            this.despesasMenuItem.Size = new System.Drawing.Size(130, 22);
            this.despesasMenuItem.Text = "Despesas";
            this.despesasMenuItem.Click += new System.EventHandler(this.despesasMenuItem_Click);
            // 
            // categoriasMenuItem
            // 
            this.categoriasMenuItem.Name = "categoriasMenuItem";
            this.categoriasMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasMenuItem.Text = "Categorias";
            this.categoriasMenuItem.Click += new System.EventHandler(this.categoriasMenuItem_Click);
            // 
            // toolbox
            // 
            this.toolbox.Enabled = false;
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.toolStripSeparator2,
            this.btnAtualizarItens,
            this.toolStripSeparator1,
            this.btnFiltrar,
            this.toolStripSeparator3,
            this.btnVisualizar,
            this.toolStripSeparator5,
            this.btnAgrupar,
            this.toolStripSeparator4,
            this.labelTipoCadastro});
            this.toolbox.Location = new System.Drawing.Point(0, 24);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(929, 41);
            this.toolbox.TabIndex = 1;
            this.toolbox.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = global::eAgenda.WinApp.Properties.Resources.outline_add_circle_outline_black_24dp;
            this.btnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(5);
            this.btnInserir.Size = new System.Drawing.Size(38, 38);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::eAgenda.WinApp.Properties.Resources.outline_mode_edit_black_24dp;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditar.Size = new System.Drawing.Size(38, 38);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::eAgenda.WinApp.Properties.Resources.outline_delete_black_24dp;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(38, 38);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // btnAtualizarItens
            // 
            this.btnAtualizarItens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtualizarItens.Image = global::eAgenda.WinApp.Properties.Resources.check_box_FILL0_wght400_GRAD0_opsz24;
            this.btnAtualizarItens.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAtualizarItens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizarItens.Name = "btnAtualizarItens";
            this.btnAtualizarItens.Padding = new System.Windows.Forms.Padding(5);
            this.btnAtualizarItens.Size = new System.Drawing.Size(38, 38);
            this.btnAtualizarItens.Click += new System.EventHandler(this.btnAtualizarItens_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Image = global::eAgenda.WinApp.Properties.Resources.outline_filter_alt_black_24dp;
            this.btnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Padding = new System.Windows.Forms.Padding(5);
            this.btnFiltrar.Size = new System.Drawing.Size(38, 38);
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVisualizar.Image = global::eAgenda.WinApp.Properties.Resources.pageview_FILL0_wght300_GRAD0_opsz24;
            this.btnVisualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Padding = new System.Windows.Forms.Padding(5);
            this.btnVisualizar.Size = new System.Drawing.Size(38, 38);
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 41);
            // 
            // btnAgrupar
            // 
            this.btnAgrupar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgrupar.Image = global::eAgenda.WinApp.Properties.Resources.outline_table_rows_black_24dp;
            this.btnAgrupar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgrupar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgrupar.Name = "btnAgrupar";
            this.btnAgrupar.Padding = new System.Windows.Forms.Padding(5);
            this.btnAgrupar.Size = new System.Drawing.Size(38, 38);
            this.btnAgrupar.Click += new System.EventHandler(this.btnAgrupar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 41);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(90, 38);
            this.labelTipoCadastro.Text = "[tipoCadastro]";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(929, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(52, 17);
            this.labelRodape.Text = "[rodapé]";
            // 
            // panelRegistros
            // 
            this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistros.Location = new System.Drawing.Point(0, 65);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(929, 522);
            this.panelRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 609);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(945, 648);
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda 2.0";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compromissosMenuItem;
        private System.Windows.Forms.ToolStrip toolbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnAtualizarItens;
        private System.Windows.Forms.ToolStripStatusLabel labelRodape;
        private System.Windows.Forms.ToolStripButton btnFiltrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel labelTipoCadastro;
        private System.Windows.Forms.ToolStripButton btnAgrupar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem despesasSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasMenuItem;
        private System.Windows.Forms.ToolStripButton btnVisualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}