namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaCadastroCompromissosForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtHoraTermino = new System.Windows.Forms.DateTimePicker();
            this.checkMarcarContato = new System.Windows.Forms.CheckBox();
            this.cmbContatos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.rdbPresencial = new System.Windows.Forms.RadioButton();
            this.rdbRemoto = new System.Windows.Forms.RadioButton();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Assunto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Número:";
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(258, 372);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(88, 52);
            this.btnGravar.TabIndex = 11;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(352, 372);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 52);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.CalendarMonthBackground = System.Drawing.Color.LightYellow;
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(75, 81);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(146, 23);
            this.txtData.TabIndex = 2;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.CalendarMonthBackground = System.Drawing.Color.LightYellow;
            this.txtHoraInicio.CustomFormat = "HH:mm";
            this.txtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHoraInicio.Location = new System.Drawing.Point(75, 113);
            this.txtHoraInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ShowUpDown = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(146, 23);
            this.txtHoraInicio.TabIndex = 3;
            // 
            // txtHoraTermino
            // 
            this.txtHoraTermino.CalendarMonthBackground = System.Drawing.Color.LightYellow;
            this.txtHoraTermino.CustomFormat = "HH:mm";
            this.txtHoraTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHoraTermino.Location = new System.Drawing.Point(293, 113);
            this.txtHoraTermino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoraTermino.Name = "txtHoraTermino";
            this.txtHoraTermino.ShowUpDown = true;
            this.txtHoraTermino.Size = new System.Drawing.Size(146, 23);
            this.txtHoraTermino.TabIndex = 4;
            // 
            // checkMarcarContato
            // 
            this.checkMarcarContato.AutoSize = true;
            this.checkMarcarContato.Location = new System.Drawing.Point(75, 155);
            this.checkMarcarContato.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkMarcarContato.Name = "checkMarcarContato";
            this.checkMarcarContato.Size = new System.Drawing.Size(277, 19);
            this.checkMarcarContato.TabIndex = 5;
            this.checkMarcarContato.Text = "Deseja marcar um contato neste compromisso?";
            this.checkMarcarContato.UseVisualStyleBackColor = true;
            this.checkMarcarContato.CheckedChanged += new System.EventHandler(this.checkMarcarContato_CheckedChanged);
            // 
            // cmbContatos
            // 
            this.cmbContatos.BackColor = System.Drawing.Color.White;
            this.cmbContatos.DisplayMember = "Nome";
            this.cmbContatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContatos.Enabled = false;
            this.cmbContatos.FormattingEnabled = true;
            this.cmbContatos.Location = new System.Drawing.Point(75, 181);
            this.cmbContatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbContatos.Name = "cmbContatos";
            this.cmbContatos.Size = new System.Drawing.Size(146, 23);
            this.cmbContatos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Início:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Término:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLocal);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Controls.Add(this.rdbPresencial);
            this.groupBox1.Controls.Add(this.rdbRemoto);
            this.groupBox1.Location = new System.Drawing.Point(75, 223);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(365, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localização";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(121, 61);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(236, 23);
            this.txtLocal.TabIndex = 11;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(121, 31);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(236, 23);
            this.txtLink.TabIndex = 9;
            // 
            // rdbPresencial
            // 
            this.rdbPresencial.AutoSize = true;
            this.rdbPresencial.Location = new System.Drawing.Point(24, 63);
            this.rdbPresencial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbPresencial.Name = "rdbPresencial";
            this.rdbPresencial.Size = new System.Drawing.Size(81, 19);
            this.rdbPresencial.TabIndex = 10;
            this.rdbPresencial.TabStop = true;
            this.rdbPresencial.Text = "Presencial:";
            this.rdbPresencial.UseVisualStyleBackColor = true;
            this.rdbPresencial.CheckedChanged += new System.EventHandler(this.rdbPresencial_CheckedChanged);
            // 
            // rdbRemoto
            // 
            this.rdbRemoto.AutoSize = true;
            this.rdbRemoto.Checked = true;
            this.rdbRemoto.Location = new System.Drawing.Point(24, 33);
            this.rdbRemoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbRemoto.Name = "rdbRemoto";
            this.rdbRemoto.Size = new System.Drawing.Size(70, 19);
            this.rdbRemoto.TabIndex = 8;
            this.rdbRemoto.TabStop = true;
            this.rdbRemoto.Text = "Remoto:";
            this.rdbRemoto.UseVisualStyleBackColor = true;
            this.rdbRemoto.CheckedChanged += new System.EventHandler(this.rdbRemoto_CheckedChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(75, 20);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 39;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(75, 50);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(365, 23);
            this.txtAssunto.TabIndex = 1;
            // 
            // TelaCadastroCompromissosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 442);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbContatos);
            this.Controls.Add(this.checkMarcarContato);
            this.Controls.Add(this.txtHoraTermino);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroCompromissosForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Compromissos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.DateTimePicker txtHoraInicio;
        private System.Windows.Forms.DateTimePicker txtHoraTermino;
        private System.Windows.Forms.CheckBox checkMarcarContato;
        private System.Windows.Forms.ComboBox cmbContatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.RadioButton rdbPresencial;
        private System.Windows.Forms.RadioButton rdbRemoto;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtAssunto;
    }
}