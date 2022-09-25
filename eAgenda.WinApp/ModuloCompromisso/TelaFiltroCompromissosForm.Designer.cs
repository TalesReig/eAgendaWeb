namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromissosForm
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
            this.rdbTodosCompromissos = new System.Windows.Forms.RadioButton();
            this.rdbCompromissosFuturos = new System.Windows.Forms.RadioButton();
            this.rdbCompromissosPassados = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.groupCompromissoFuturos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupCompromissoFuturos.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbTodosCompromissos
            // 
            this.rdbTodosCompromissos.AutoSize = true;
            this.rdbTodosCompromissos.Checked = true;
            this.rdbTodosCompromissos.Location = new System.Drawing.Point(35, 44);
            this.rdbTodosCompromissos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdbTodosCompromissos.Name = "rdbTodosCompromissos";
            this.rdbTodosCompromissos.Size = new System.Drawing.Size(255, 24);
            this.rdbTodosCompromissos.TabIndex = 4;
            this.rdbTodosCompromissos.TabStop = true;
            this.rdbTodosCompromissos.Text = "Visualizar todas os Compromissos";
            this.rdbTodosCompromissos.UseVisualStyleBackColor = true;
            this.rdbTodosCompromissos.CheckedChanged += new System.EventHandler(this.rdbTodosCompromissos_CheckedChanged);
            // 
            // rdbCompromissosFuturos
            // 
            this.rdbCompromissosFuturos.AutoSize = true;
            this.rdbCompromissosFuturos.Location = new System.Drawing.Point(35, 145);
            this.rdbCompromissosFuturos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdbCompromissosFuturos.Name = "rdbCompromissosFuturos";
            this.rdbCompromissosFuturos.Size = new System.Drawing.Size(308, 24);
            this.rdbCompromissosFuturos.TabIndex = 5;
            this.rdbCompromissosFuturos.Text = "Visualizar somente Compromissos Futuros";
            this.rdbCompromissosFuturos.UseVisualStyleBackColor = true;
            this.rdbCompromissosFuturos.CheckedChanged += new System.EventHandler(this.rdbCompromissosFuturos_CheckedChanged);
            // 
            // rdbCompromissosPassados
            // 
            this.rdbCompromissosPassados.AutoSize = true;
            this.rdbCompromissosPassados.Location = new System.Drawing.Point(35, 95);
            this.rdbCompromissosPassados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdbCompromissosPassados.Name = "rdbCompromissosPassados";
            this.rdbCompromissosPassados.Size = new System.Drawing.Size(319, 24);
            this.rdbCompromissosPassados.TabIndex = 6;
            this.rdbCompromissosPassados.Text = "Visualizar somente Compromissos Passados";
            this.rdbCompromissosPassados.UseVisualStyleBackColor = true;
            this.rdbCompromissosPassados.CheckedChanged += new System.EventHandler(this.rdbCompromissosPassados_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(418, 329);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 52);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(326, 329);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(82, 52);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicial.Location = new System.Drawing.Point(99, 47);
            this.txtDataInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(113, 27);
            this.txtDataInicial.TabIndex = 10;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(319, 47);
            this.txtDataFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(123, 27);
            this.txtDataFinal.TabIndex = 11;
            // 
            // groupCompromissoFuturos
            // 
            this.groupCompromissoFuturos.Controls.Add(this.label2);
            this.groupCompromissoFuturos.Controls.Add(this.label1);
            this.groupCompromissoFuturos.Controls.Add(this.txtDataInicial);
            this.groupCompromissoFuturos.Controls.Add(this.txtDataFinal);
            this.groupCompromissoFuturos.Location = new System.Drawing.Point(35, 200);
            this.groupCompromissoFuturos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupCompromissoFuturos.Name = "groupCompromissoFuturos";
            this.groupCompromissoFuturos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupCompromissoFuturos.Size = new System.Drawing.Size(465, 109);
            this.groupCompromissoFuturos.TabIndex = 12;
            this.groupCompromissoFuturos.TabStop = false;
            this.groupCompromissoFuturos.Text = "Filtro paras os Compromissos Futuros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data Inicial:";
            // 
            // TelaFiltroCompromissosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 415);
            this.Controls.Add(this.rdbCompromissosFuturos);
            this.Controls.Add(this.groupCompromissoFuturos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.rdbCompromissosPassados);
            this.Controls.Add(this.rdbTodosCompromissos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaFiltroCompromissosForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Compromissos";
            this.groupCompromissoFuturos.ResumeLayout(false);
            this.groupCompromissoFuturos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbTodosCompromissos;
        private System.Windows.Forms.RadioButton rdbCompromissosFuturos;
        private System.Windows.Forms.RadioButton rdbCompromissosPassados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.GroupBox groupCompromissoFuturos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}