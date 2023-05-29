namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaCadastroItensTarefaForm
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
            txtTitulo = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            listItens = new ListBox();
            txtItemDescricao = new TextBox();
            label3 = new Label();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(90, 62);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(355, 29);
            txtTitulo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 65);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 12;
            label2.Text = "Título:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(90, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(60, 29);
            txtId.TabIndex = 11;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 16);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 10;
            label1.Text = "Id:";
            // 
            // listItens
            // 
            listItens.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 21;
            listItens.Location = new Point(90, 156);
            listItens.Name = "listItens";
            listItens.Size = new Size(355, 256);
            listItens.TabIndex = 16;
            // 
            // txtItemDescricao
            // 
            txtItemDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescricao.Location = new Point(90, 107);
            txtItemDescricao.Name = "txtItemDescricao";
            txtItemDescricao.Size = new Size(274, 29);
            txtItemDescricao.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 17;
            label3.Text = "Descrição:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(370, 107);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 29);
            btnAdicionar.TabIndex = 19;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(353, 441);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 56;
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
            btnGravar.Location = new Point(238, 441);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 55;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 156);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 57;
            label4.Text = "To-Do:";
            // 
            // TelaCadastroItensTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 506);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtItemDescricao);
            Controls.Add(label3);
            Controls.Add(listItens);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaCadastroItensTarefaForm";
            Text = "Cadastro de Itens da Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private ListBox listItens;
        private TextBox txtItemDescricao;
        private Label label3;
        private Button btnAdicionar;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label4;
    }
}