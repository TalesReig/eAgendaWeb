namespace eAgenda.WinApp.ModuloContato
{
    partial class TelaAgrupamentoContatoForm
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
            this.btnAgrupar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdbAgruparPorCargo = new System.Windows.Forms.RadioButton();
            this.rdbAgruparPorEmpresa = new System.Windows.Forms.RadioButton();
            this.rdbSemAgrupamento = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAgrupar
            // 
            this.btnAgrupar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgrupar.Location = new System.Drawing.Point(261, 256);
            this.btnAgrupar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgrupar.Name = "btnAgrupar";
            this.btnAgrupar.Size = new System.Drawing.Size(88, 45);
            this.btnAgrupar.TabIndex = 15;
            this.btnAgrupar.Text = "Agrupar";
            this.btnAgrupar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(356, 256);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 45);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbAgruparPorCargo
            // 
            this.rdbAgruparPorCargo.AutoSize = true;
            this.rdbAgruparPorCargo.Location = new System.Drawing.Point(33, 95);
            this.rdbAgruparPorCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbAgruparPorCargo.Name = "rdbAgruparPorCargo";
            this.rdbAgruparPorCargo.Size = new System.Drawing.Size(236, 19);
            this.rdbAgruparPorCargo.TabIndex = 19;
            this.rdbAgruparPorCargo.Text = "Visualizar contatos agrupados por cargo";
            this.rdbAgruparPorCargo.UseVisualStyleBackColor = true;
            // 
            // rdbAgruparPorEmpresa
            // 
            this.rdbAgruparPorEmpresa.AutoSize = true;
            this.rdbAgruparPorEmpresa.Location = new System.Drawing.Point(33, 62);
            this.rdbAgruparPorEmpresa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbAgruparPorEmpresa.Name = "rdbAgruparPorEmpresa";
            this.rdbAgruparPorEmpresa.Size = new System.Drawing.Size(251, 19);
            this.rdbAgruparPorEmpresa.TabIndex = 17;
            this.rdbAgruparPorEmpresa.Text = "Visualizar contatos agrupados por empresa";
            this.rdbAgruparPorEmpresa.UseVisualStyleBackColor = true;
            // 
            // rdbSemAgrupamento
            // 
            this.rdbSemAgrupamento.AutoSize = true;
            this.rdbSemAgrupamento.Checked = true;
            this.rdbSemAgrupamento.Location = new System.Drawing.Point(33, 30);
            this.rdbSemAgrupamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbSemAgrupamento.Name = "rdbSemAgrupamento";
            this.rdbSemAgrupamento.Size = new System.Drawing.Size(223, 19);
            this.rdbSemAgrupamento.TabIndex = 20;
            this.rdbSemAgrupamento.TabStop = true;
            this.rdbSemAgrupamento.Text = "Visualizar contatos sem agrupamento";
            this.rdbSemAgrupamento.UseVisualStyleBackColor = true;
            // 
            // TelaAgrupamentoContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 315);
            this.Controls.Add(this.rdbSemAgrupamento);
            this.Controls.Add(this.rdbAgruparPorCargo);
            this.Controls.Add(this.rdbAgruparPorEmpresa);
            this.Controls.Add(this.btnAgrupar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAgrupamentoContatoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrupamento de Contatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgrupar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdbAgruparPorCargo;
        private System.Windows.Forms.RadioButton rdbAgruparPorEmpresa;
        private System.Windows.Forms.RadioButton rdbSemAgrupamento;
    }
}