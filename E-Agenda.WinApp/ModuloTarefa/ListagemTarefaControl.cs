using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl
    {
        List<Tarefa> tarefas = new List<Tarefa>();

        public ListagemTarefaControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Empresa", HeaderText = "Empresa"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Cargo", HeaderText = "Cargo"}
            };

            return colunas;
        }

        public int ObterNumeroContatoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            grid.Rows.Clear();

            foreach (var contato in contatos)
            {
                grid.Rows.Add(contato.id, contato.informacoesPessoais.nome,
                    contato.informacoesPessoais.telefone, contato.informacoesPessoais.email, contato.empresa,
                    contato.cargo);
            }
        }
    }
}

