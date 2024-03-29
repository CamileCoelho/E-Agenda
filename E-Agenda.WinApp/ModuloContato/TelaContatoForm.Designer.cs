﻿namespace E_Agenda.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtEmpresa = new TextBox();
            txtEmail = new TextBox();
            txtCargo = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtTelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 172);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 27;
            label6.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(295, 175);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 26;
            label5.Text = "Empresa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(311, 131);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 25;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 123);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 24;
            label3.Text = "Telefone:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpresa.Location = new Point(374, 172);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(209, 29);
            txtEmpresa.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(374, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 29);
            txtEmail.TabIndex = 22;
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.Location = new Point(90, 172);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(195, 29);
            txtCargo.TabIndex = 21;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(91, 78);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(492, 29);
            txtNome.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 78);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 18;
            label2.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(91, 35);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(112, 29);
            txtId.TabIndex = 17;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 35);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 16;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(490, 230);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.ImageAlign = ContentAlignment.BottomRight;
            btnGravar.Location = new Point(375, 230);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(91, 123);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(194, 29);
            txtTelefone.TabIndex = 28;
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 297);
            Controls.Add(txtTelefone);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmpresa);
            Controls.Add(txtEmail);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(632, 336);
            MinimizeBox = false;
            MinimumSize = new Size(632, 336);
            Name = "TelaContatoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtEmpresa;
        private TextBox txtEmail;
        private TextBox txtCargo;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private MaskedTextBox txtTelefone;
    }
}