using E_Agenda.WinApp.ModuloCompromissos;

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
                cmbPrioridades.SelectedItem = value.prioridade;
            }
            get
            {
                return tarefa;
            }
        }
        public void CarregarPrioridades()
        {
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Alta.ToString());
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Normal.ToString());
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Baixa.ToString());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            string prioridade = (string)cmbPrioridades.SelectedItem;

            tarefa = new Tarefa(titulo, prioridade);

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
