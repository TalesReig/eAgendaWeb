namespace eAgenda.WinApp.ModuloTarefa
{
    partial class ListagemTarefasControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listTarefas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listTarefas
            // 
            this.listTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTarefas.FormattingEnabled = true;
            this.listTarefas.ItemHeight = 15;
            this.listTarefas.Location = new System.Drawing.Point(0, 0);
            this.listTarefas.Name = "listTarefas";
            this.listTarefas.Size = new System.Drawing.Size(534, 425);
            this.listTarefas.TabIndex = 1;
            // 
            // ListagemTarefasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listTarefas);
            this.Name = "ListagemTarefasControl";
            this.Size = new System.Drawing.Size(534, 425);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listTarefas;
    }
}
