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

            CarregarPrioridades();
        }

        public Tarefa Tarefa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
                txtDescricao.Text = value.descricao;
                cmbPrioridades.SelectedItem = value.prioridade;
            }
            get
            {
                return tarefa;
            }
        }
        public void CarregarPrioridades()
        {
            cmbPrioridades.Items.Add("Alta");
            cmbPrioridades.Items.Add("Média");
            cmbPrioridades.Items.Add("Baixa");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            string descricao = txtDescricao.Text;

            string prioridade = (string)cmbPrioridades.SelectedItem;

            tarefa = new Tarefa(titulo, descricao, prioridade);

            string status = tarefa.validar();

            if (status != "")
            {
                TelaPrincipalForm.Tela.atualizarRodape(status);

                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                tarefa.id = Convert.ToInt32(txtId.Text);
        }
    }
}
