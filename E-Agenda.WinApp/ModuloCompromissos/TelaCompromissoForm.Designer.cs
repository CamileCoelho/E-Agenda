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
            groupBox1 = new GroupBox();
            txtLink = new TextBox();
            txtLocal = new TextBox();
            rbRemoto = new RadioButton();
            rBPresencial = new RadioButton();
            ckbCompromisso = new CheckBox();
            label7 = new Label();
            label2 = new Label();
            dateTimeData = new DateTimePicker();
            cmbContatos = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtAssunto = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            dateTimeTermino = new DateTimePicker();
            dateTimeInicio = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLink);
            groupBox1.Controls.Add(txtLocal);
            groupBox1.Controls.Add(rbRemoto);
            groupBox1.Controls.Add(rBPresencial);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(22, 299);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 150);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Localização";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(133, 99);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(260, 29);
            txtLink.TabIndex = 39;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(133, 48);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(260, 29);
            txtLocal.TabIndex = 38;
            // 
            // rbRemoto
            // 
            rbRemoto.Location = new Point(17, 99);
            rbRemoto.Name = "rbRemoto";
            rbRemoto.Size = new Size(98, 24);
            rbRemoto.TabIndex = 40;
            rbRemoto.Text = "Remoto";
            // 
            // rBPresencial
            // 
            rBPresencial.AutoSize = true;
            rBPresencial.Location = new Point(17, 48);
            rBPresencial.Name = "rBPresencial";
            rBPresencial.Size = new Size(98, 25);
            rBPresencial.TabIndex = 0;
            rBPresencial.TabStop = true;
            rBPresencial.Text = "Presencial";
            rBPresencial.UseVisualStyleBackColor = true;
            // 
            // ckbCompromisso
            // 
            ckbCompromisso.AutoSize = true;
            ckbCompromisso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckbCompromisso.Location = new Point(39, 201);
            ckbCompromisso.Name = "ckbCompromisso";
            ckbCompromisso.Size = new Size(360, 25);
            ckbCompromisso.TabIndex = 51;
            ckbCompromisso.Text = "Deseja marcar um contato nesse compromisso?";
            ckbCompromisso.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(39, 251);
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
            // dateTimeData
            // 
            dateTimeData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeData.Location = new Point(89, 125);
            dateTimeData.Name = "dateTimeData";
            dateTimeData.Size = new Size(364, 29);
            dateTimeData.TabIndex = 46;
            dateTimeData.Value = new DateTime(2023, 5, 18, 9, 25, 16, 0);
            // 
            // cmbContatos
            // 
            cmbContatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(113, 251);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(340, 29);
            cmbContatos.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(507, 125);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 44;
            label6.Text = "Horário de início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(489, 173);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 43;
            label5.Text = "Horário de término:";
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
            txtAssunto.Size = new Size(682, 29);
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
            btnCancelar.Location = new Point(662, 408);
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
            btnGravar.Location = new Point(547, 408);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 53;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(651, 125);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 29);
            numericUpDown1.TabIndex = 55;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(651, 173);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 29);
            numericUpDown2.TabIndex = 56;
            // 
            // dateTimeTermino
            // 
            dateTimeTermino.CustomFormat = "\"HH:mm\"";
            dateTimeTermino.Location = new Point(486, 201);
            dateTimeTermino.Name = "dateTimeTermino";
            dateTimeTermino.Size = new Size(149, 23);
            dateTimeTermino.TabIndex = 58;
            dateTimeTermino.Value = new DateTime(2023, 5, 17, 15, 51, 0, 0);
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.CustomFormat = "HH:mm";
            dateTimeInicio.Location = new Point(486, 147);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(149, 23);
            dateTimeInicio.TabIndex = 57;
            dateTimeInicio.Value = new DateTime(2023, 5, 17, 15, 51, 0, 0);
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 479);
            Controls.Add(dateTimeTermino);
            Controls.Add(dateTimeInicio);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(ckbCompromisso);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(dateTimeData);
            Controls.Add(cmbContatos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaCompromissoForm";
            Text = "TelaCompromissoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtLink;
        private TextBox txtLocal;
        private RadioButton rbRemoto;
        private RadioButton rBPresencial;
        private CheckBox ckbCompromisso;
        private Label label7;
        private Label label2;
        private DateTimePicker dateTimeData;
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
        private DateTimePicker dateTimeTermino;
        private DateTimePicker dateTimeInicio;
    }
}