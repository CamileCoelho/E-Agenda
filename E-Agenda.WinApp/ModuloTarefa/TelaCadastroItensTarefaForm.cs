using E_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaCadastroItensTarefaForm : Form
    {
        public TelaCadastroItensTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefa);
        }

        private void ConfigurarTela(Tarefa tarefa)
        {
            txtId.Text = tarefa.id.ToString();

            txtTitulo.Text = tarefa.titulo;

            listItens.Items.AddRange(tarefa.itens.ToArray());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string item = txtItemDescricao.Text;

            if(string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
            {
                MessageBox.Show($"Você deve preencher o a descrição!",
                    "Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            foreach (ItemTarefa i in listItens.Items)
            {
                if (item.Trim() == i.ToString().Trim())
                {
                    MessageBox.Show($"Você não pode adicionar dois itens com a mesma descrição em sua To-Do List!",
                    "Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    return;
                }
            }

            txtItemDescricao.Text = "";

            ItemTarefa itemTarefa = new(item);

            listItens.Items.Add(itemTarefa);
        }

        public List<ItemTarefa> ObterItensCadastrados()
        {
            return listItens.Items.Cast<ItemTarefa>().ToList();
        }
    }
}
