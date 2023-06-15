using E_Agenda.Dominio.ModuloTarefa;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Título", HeaderText = "Título"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Prioridade", HeaderText = "Prioridade"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data de Criação", HeaderText = "Data de Criação"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade de itens", HeaderText = "Quantidade de itens"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Porcentagem de Conclusão", HeaderText = "Porcentagem de Conclusão"},

            };

            return colunas;
        }

        public int ObterNumeroTarefaSelecionada()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            grid.Rows.Clear();

            foreach (var tarefa in tarefas)
            {
                grid.Rows.Add(tarefa.id, tarefa.titulo,
                   tarefa.prioridade, DateOnly.FromDateTime(tarefa.dataCriacao),
                   tarefa.itens.Count(), tarefa.percentualConcluido+"%");
            }
        }
    }
}

