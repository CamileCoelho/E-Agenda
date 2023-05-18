namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl
    {
        List<Tarefa> tarefas = new List<Tarefa>();

        public ListagemTarefaControl()
        {
            InitializeComponent();

        }
        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                listTarefas.Items.Add(tarefa);
            }
        }

        public Tarefa ObterTarefaSelecionada()
        {
            return (Tarefa)listTarefas.SelectedItem;
        }
    }
}

