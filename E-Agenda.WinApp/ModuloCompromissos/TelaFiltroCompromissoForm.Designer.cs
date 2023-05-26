namespace E_Agenda.WinApp.ModuloCompromissos
{
    partial class TelaFiltroCompromissoForm
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
            btnCancelar = new Button();
            btnFiltrar = new Button();
            rbdTodos = new RadioButton();
            rdbFuturos = new RadioButton();
            rbdPassados = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            txtDataFinal = new DateTimePicker();
            txtDataInicio = new DateTimePicker();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(258, 336);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltrar.ImageAlign = ContentAlignment.BottomRight;
            btnFiltrar.Location = new Point(143, 336);
            btnFiltrar.Margin = new Padding(4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 41);
            btnFiltrar.TabIndex = 16;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // rbdTodos
            // 
            rbdTodos.AutoSize = true;
            rbdTodos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbdTodos.Location = new Point(61, 39);
            rbdTodos.Name = "rbdTodos";
            rbdTodos.Size = new Size(264, 25);
            rbdTodos.TabIndex = 18;
            rbdTodos.TabStop = true;
            rbdTodos.Text = "Visualizar todos os compromissos";
            rbdTodos.UseVisualStyleBackColor = true;
            // 
            // rdbFuturos
            // 
            rdbFuturos.AutoSize = true;
            rdbFuturos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbFuturos.Location = new Point(61, 131);
            rdbFuturos.Name = "rdbFuturos";
            rdbFuturos.Size = new Size(255, 25);
            rdbFuturos.TabIndex = 19;
            rdbFuturos.TabStop = true;
            rdbFuturos.Text = "Visualizar compromissos futuros";
            rdbFuturos.UseVisualStyleBackColor = true;
            // 
            // rbdPassados
            // 
            rbdPassados.AutoSize = true;
            rbdPassados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbdPassados.Location = new Point(61, 85);
            rbdPassados.Name = "rbdPassados";
            rbdPassados.Size = new Size(273, 25);
            rbdPassados.TabIndex = 20;
            rbdPassados.TabStop = true;
            rbdPassados.Text = "Visualizar compromissos passados ";
            rbdPassados.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 244);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 24;
            label2.Text = "Data Final:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 206);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 23;
            label1.Text = "Data Inicial:";
            // 
            // txtDataFinal
            // 
            txtDataFinal.Enabled = false;
            txtDataFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataFinal.Format = DateTimePickerFormat.Short;
            txtDataFinal.Location = new Point(165, 244);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(187, 29);
            txtDataFinal.TabIndex = 22;
            // 
            // txtDataInicio
            // 
            txtDataInicio.Enabled = false;
            txtDataInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataInicio.Format = DateTimePickerFormat.Short;
            txtDataInicio.Location = new Point(165, 206);
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.Size = new Size(187, 29);
            txtDataInicio.TabIndex = 21;
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 406);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDataFinal);
            Controls.Add(txtDataInicio);
            Controls.Add(rbdPassados);
            Controls.Add(rdbFuturos);
            Controls.Add(rbdTodos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Name = "TelaFiltroCompromissoForm";
            Text = "TelaFiltroCompromissoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnFiltrar;
        private RadioButton rbdTodos;
        private RadioButton rdbFuturos;
        private RadioButton rbdPassados;
        private Label label2;
        private Label label1;
        private DateTimePicker txtDataFinal;
        private DateTimePicker txtDataInicio;
    }
}