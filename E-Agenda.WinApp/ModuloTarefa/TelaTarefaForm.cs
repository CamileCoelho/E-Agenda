using E_Agenda.WinApp.ModuloCompromissos;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;

        public TelaTarefaForm(bool edicaoDaTarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarPrioridades();

            if (edicaoDaTarefa)
            {
                txtDataCriacao.Enabled = false;
            }
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
        public Tarefa ObterTarefa()
        {
            string titulo = txtTitulo.Text;

            TipoPrioridadeTarefaEnum prioridade = (TipoPrioridadeTarefaEnum)cmbPrioridades.SelectedItem;

            DateTime dataCriacao = txtDataCriacao.Value;

            return new Tarefa(id, titulo, prioridade, dataCriacao);
        }
        public void CarregarPrioridades()
        {
            //TipoPrioridadeTarefaEnum[] prioridades = Enum.GetValues<TipoPrioridadeTarefaEnum>();

            //foreach (TipoPrioridadeTarefaEnum prioridade in prioridades)
            //{
            //    cmbPrioridades.Items.Add(prioridade);
            //}
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Alta.ToString());
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Normal.ToString());
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Baixa.ToString());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            TipoPrioridadeTarefaEnum prioridade = (TipoPrioridadeTarefaEnum)cmbPrioridades.SelectedItem;

            tarefa = new Tarefa(titulo, prioridade);

            string status = tarefa.Validar();

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
