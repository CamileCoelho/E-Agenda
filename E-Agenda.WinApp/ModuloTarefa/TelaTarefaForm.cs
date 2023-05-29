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

        public Tarefa ObterTarefa()
        {
            string titulo = txtTitulo.Text;

            TipoPrioridadeTarefaEnum prioridade = TipoPrioridadeTarefaEnum.Nenhuma;

            if (cmbPrioridades.SelectedItem == null)
            {
                prioridade = TipoPrioridadeTarefaEnum.Nenhuma;
            }
            if (cmbPrioridades.SelectedItem != null)
            {
                prioridade = (TipoPrioridadeTarefaEnum)cmbPrioridades.SelectedItem;
            }

            DateTime dataCriacao = txtDataCriacao.Value;

            return new ( titulo, prioridade, dataCriacao );
        }

        public void CarregarPrioridades()
        {
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Alta);
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Normal);
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Baixa);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tarefa = ObterTarefa();

            string status = tarefa.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
                DialogResult = DialogResult.None;
        }
    }
}
