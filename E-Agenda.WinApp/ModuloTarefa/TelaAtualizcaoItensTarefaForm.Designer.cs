namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaAtualizacaoItensTarefaForm
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
            listItensTarefa = new CheckedListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(77, 65);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(355, 29);
            txtTitulo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 68);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 12;
            label2.Text = "Título:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(77, 12);
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
            label1.Location = new Point(51, 16);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 10;
            label1.Text = "Id:";
            // 
            // listItensTarefa
            // 
            listItensTarefa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listItensTarefa.FormattingEnabled = true;
            listItensTarefa.Location = new Point(64, 119);
            listItensTarefa.Name = "listItensTarefa";
            listItensTarefa.Size = new Size(370, 292);
            listItensTarefa.TabIndex = 17;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(340, 438);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 58;
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
            btnGravar.Location = new Point(225, 438);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 57;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // TelaAtualizacaoItensTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 508);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(listItensTarefa);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaAtualizacaoItensTarefaForm";
            Text = "Atualização de Itens da Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private CheckedListBox listItensTarefa;
        private Button btnCancelar;
        private Button btnGravar;
    }
}