using E_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;

        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
                txtDescricao.Text = value.descricao;
                txtPrioridade.Text = value.prioridade;
            }
            get
            {
                return tarefa;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            string descricao = txtDescricao.Text;

            string prioridade = txtPrioridade.Text;

            tarefa = new Tarefa(titulo, descricao, prioridade);

            if (txtId.Text != "0")
                tarefa.id = Convert.ToInt32(txtId.Text);
        }
    }
}
