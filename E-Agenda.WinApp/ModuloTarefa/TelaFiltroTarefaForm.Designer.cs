namespace e_Agenda.WinApp.ModuloTarefa
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
            rdbTodos = new RadioButton();
            rdbPendentes = new RadioButton();
            rdbConcluidas = new RadioButton();
            btnCancelar = new Button();
            btnFiltrar = new Button();
            SuspendLayout();
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize = true;
            rdbTodos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTodos.Location = new Point(34, 31);
            rdbTodos.Name = "rdbTodos";
            rdbTodos.Size = new Size(209, 25);
            rdbTodos.TabIndex = 2;
            rdbTodos.TabStop = true;
            rdbTodos.Text = "Visualizar Todas as Tarefas";
            rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbPendentes
            // 
            rdbPendentes.AutoSize = true;
            rdbPendentes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPendentes.Location = new Point(34, 68);
            rdbPendentes.Name = "rdbPendentes";
            rdbPendentes.Size = new Size(222, 25);
            rdbPendentes.TabIndex = 3;
            rdbPendentes.TabStop = true;
            rdbPendentes.Text = "Visualizar Tarefas Pendentes";
            rdbPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbConcluidas
            // 
            rdbConcluidas.AutoSize = true;
            rdbConcluidas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbConcluidas.Location = new Point(34, 106);
            rdbConcluidas.Name = "rdbConcluidas";
            rdbConcluidas.Size = new Size(227, 25);
            rdbConcluidas.TabIndex = 4;
            rdbConcluidas.TabStop = true;
            rdbConcluidas.Text = "Visualizar Tarefas Concluídas";
            rdbConcluidas.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(197, 189);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 19;
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
            btnFiltrar.Location = new Point(82, 189);
            btnFiltrar.Margin = new Padding(4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 41);
            btnFiltrar.TabIndex = 18;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 262);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Controls.Add(rdbConcluidas);
            Controls.Add(rdbPendentes);
            Controls.Add(rdbTodos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroTarefaForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rdbTodos;
        private RadioButton rdbPendentes;
        private RadioButton rdbConcluidas;
        private Button btnCancelar;
        private Button btnFiltrar;
    }
}