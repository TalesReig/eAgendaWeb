namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaFiltroTarefaForm
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
            this.rdbTodasTarefas = new System.Windows.Forms.RadioButton();
            this.rdbTarefasPendentes = new System.Windows.Forms.RadioButton();
            this.rdbTarefasConcluidas = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbTodasTarefas
            // 
            this.rdbTodasTarefas.AutoSize = true;
            this.rdbTodasTarefas.Location = new System.Drawing.Point(31, 33);
            this.rdbTodasTarefas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbTodasTarefas.Name = "rdbTodasTarefas";
            this.rdbTodasTarefas.Size = new System.Drawing.Size(159, 19);
            this.rdbTodasTarefas.TabIndex = 4;
            this.rdbTodasTarefas.TabStop = true;
            this.rdbTodasTarefas.Text = "Visualizar todas as Tarefas";
            this.rdbTodasTarefas.UseVisualStyleBackColor = true;
            // 
            // rdbTarefasPendentes
            // 
            this.rdbTarefasPendentes.AutoSize = true;
            this.rdbTarefasPendentes.Location = new System.Drawing.Point(31, 73);
            this.rdbTarefasPendentes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbTarefasPendentes.Name = "rdbTarefasPendentes";
            this.rdbTarefasPendentes.Size = new System.Drawing.Size(220, 19);
            this.rdbTarefasPendentes.TabIndex = 5;
            this.rdbTarefasPendentes.TabStop = true;
            this.rdbTarefasPendentes.Text = "Visualizar somente Tarefas Pendentes";
            this.rdbTarefasPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbTarefasConcluidas
            // 
            this.rdbTarefasConcluidas.AutoSize = true;
            this.rdbTarefasConcluidas.Location = new System.Drawing.Point(31, 112);
            this.rdbTarefasConcluidas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbTarefasConcluidas.Name = "rdbTarefasConcluidas";
            this.rdbTarefasConcluidas.Size = new System.Drawing.Size(224, 19);
            this.rdbTarefasConcluidas.TabIndex = 6;
            this.rdbTarefasConcluidas.TabStop = true;
            this.rdbTarefasConcluidas.Text = "Visualizar somente Tarefas Concluídas";
            this.rdbTarefasConcluidas.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(343, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 39);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(262, 219);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(72, 39);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroTarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 270);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.rdbTarefasConcluidas);
            this.Controls.Add(this.rdbTarefasPendentes);
            this.Controls.Add(this.rdbTodasTarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaFiltroTarefaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbTodasTarefas;
        private System.Windows.Forms.RadioButton rdbTarefasPendentes;
        private System.Windows.Forms.RadioButton rdbTarefasConcluidas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}