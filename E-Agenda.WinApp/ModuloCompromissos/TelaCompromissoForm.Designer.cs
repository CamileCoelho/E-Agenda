namespace E_Agenda.WinApp.ModuloCompromissos
{
    partial class TelaCompromissoForm
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
            groupBoxLocalizacao = new GroupBox();
            txtLocalOnline = new TextBox();
            txtLocalPresencial = new TextBox();
            rbtOnline = new RadioButton();
            rbtPresencial = new RadioButton();
            chkSelecionarContato = new CheckBox();
            label7 = new Label();
            label2 = new Label();
            txtData = new DateTimePicker();
            cmbContatos = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtAssunto = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtTermino = new DateTimePicker();
            txtInicio = new DateTimePicker();
            groupBoxLocalizacao.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLocalizacao
            // 
            groupBoxLocalizacao.BackColor = SystemColors.Control;
            groupBoxLocalizacao.Controls.Add(txtLocalOnline);
            groupBoxLocalizacao.Controls.Add(txtLocalPresencial);
            groupBoxLocalizacao.Controls.Add(rbtOnline);
            groupBoxLocalizacao.Controls.Add(rbtPresencial);
            groupBoxLocalizacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxLocalizacao.Location = new Point(15, 346);
            groupBoxLocalizacao.Name = "groupBoxLocalizacao";
            groupBoxLocalizacao.Size = new Size(465, 160);
            groupBoxLocalizacao.TabIndex = 52;
            groupBoxLocalizacao.TabStop = false;
            groupBoxLocalizacao.Text = "Localização";
            // 
            // txtLocalOnline
            // 
            txtLocalOnline.Location = new Point(133, 99);
            txtLocalOnline.Name = "txtLocalOnline";
            txtLocalOnline.Size = new Size(300, 29);
            txtLocalOnline.TabIndex = 39;
            // 
            // txtLocalPresencial
            // 
            txtLocalPresencial.Location = new Point(133, 48);
            txtLocalPresencial.Name = "txtLocalPresencial";
            txtLocalPresencial.Size = new Size(300, 29);
            txtLocalPresencial.TabIndex = 38;
            // 
            // rbtOnline
            // 
            rbtOnline.Location = new Point(17, 99);
            rbtOnline.Name = "rbtOnline";
            rbtOnline.Size = new Size(98, 24);
            rbtOnline.TabIndex = 40;
            rbtOnline.Text = "Online";
            rbtOnline.CheckedChanged += rbtOnline_CheckedChanged;
            // 
            // rbtPresencial
            // 
            rbtPresencial.AutoSize = true;
            rbtPresencial.Location = new Point(17, 48);
            rbtPresencial.Name = "rbtPresencial";
            rbtPresencial.Size = new Size(98, 25);
            rbtPresencial.TabIndex = 0;
            rbtPresencial.TabStop = true;
            rbtPresencial.Text = "Presencial";
            rbtPresencial.UseVisualStyleBackColor = true;
            rbtPresencial.CheckedChanged += rbtPresencial_CheckedChanged;
            // 
            // chkSelecionarContato
            // 
            chkSelecionarContato.AutoSize = true;
            chkSelecionarContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkSelecionarContato.Location = new Point(50, 234);
            chkSelecionarContato.Name = "chkSelecionarContato";
            chkSelecionarContato.Size = new Size(398, 25);
            chkSelecionarContato.TabIndex = 51;
            chkSelecionarContato.Text = "Deseja selecionar um contato para esse comprmisso?";
            chkSelecionarContato.UseVisualStyleBackColor = true;
            chkSelecionarContato.CheckedChanged += chkSelecionarContato_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 288);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 48;
            label7.Text = "Contato:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 125);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 47;
            label2.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(89, 125);
            txtData.Name = "txtData";
            txtData.Size = new Size(149, 29);
            txtData.TabIndex = 46;
            txtData.Value = new DateTime(2023, 5, 18, 9, 25, 16, 0);
            // 
            // cmbContatos
            // 
            cmbContatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(89, 288);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(391, 29);
            cmbContatos.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 174);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 44;
            label6.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(256, 177);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 43;
            label5.Text = "Término:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 65);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 42;
            label3.Text = "Assunto:";
            // 
            // txtAssunto
            // 
            txtAssunto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAssunto.Location = new Point(89, 65);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(391, 29);
            txtAssunto.TabIndex = 41;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(89, 11);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 29);
            txtId.TabIndex = 40;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 39;
            label1.Text = "Número:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(387, 533);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 54;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.ImageAlign = ContentAlignment.BottomRight;
            btnGravar.Location = new Point(272, 533);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 53;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtTermino
            // 
            txtTermino.CustomFormat = "HH:mm";
            txtTermino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTermino.Format = DateTimePickerFormat.Custom;
            txtTermino.Location = new Point(331, 176);
            txtTermino.Name = "txtTermino";
            txtTermino.ShowUpDown = true;
            txtTermino.Size = new Size(149, 29);
            txtTermino.TabIndex = 58;
            txtTermino.Value = new DateTime(2023, 5, 17, 15, 51, 0, 0);
            // 
            // txtInicio
            // 
            txtInicio.CustomFormat = "HH:mm";
            txtInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInicio.Format = DateTimePickerFormat.Custom;
            txtInicio.Location = new Point(89, 174);
            txtInicio.Name = "txtInicio";
            txtInicio.ShowUpDown = true;
            txtInicio.Size = new Size(149, 29);
            txtInicio.TabIndex = 57;
            txtInicio.Value = new DateTime(2023, 5, 17, 15, 51, 0, 0);
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 604);
            Controls.Add(txtTermino);
            Controls.Add(txtInicio);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBoxLocalizacao);
            Controls.Add(chkSelecionarContato);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txtData);
            Controls.Add(cmbContatos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            Controls.Add(label1);
            MaximumSize = new Size(535, 643);
            MinimumSize = new Size(535, 643);
            Name = "TelaCompromissoForm";
            Text = "TelaCompromissoForm";
            groupBoxLocalizacao.ResumeLayout(false);
            groupBoxLocalizacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxLocalizacao;
        private TextBox txtLocalOnline;
        private TextBox txtLocalPresencial;
        private RadioButton rbRemoto;
        private RadioButton rBPresencial;
        private CheckBox chkSelecionarContato;
        private Label label7;
        private Label label2;
        private DateTimePicker txtData;
        private ComboBox cmbContatos;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtAssunto;
        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private DateTimePicker txtTermino;
        private DateTimePicker txtInicio;
        private RadioButton rbtOnline;
        private RadioButton rbtPresencial;
    }
}