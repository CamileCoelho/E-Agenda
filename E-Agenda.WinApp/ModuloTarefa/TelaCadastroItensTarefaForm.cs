
namespace E_Agenda.WinApp.ModuloTarefa
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
            string item = txtItemDescricao.Text.Trim();

            if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
            {
                TelaPrincipalForm.Tela.AtualizarRodape("Você deve preencher o a descrição!");
                return;
            }

            foreach (ItemTarefa i in listItens.Items)
            {
                if (item == i.ToString().Trim())
                {
                    TelaPrincipalForm.Tela.AtualizarRodape("Você não pode adicionar dois itens" +
                        " com a mesma descrição em sua To-Do List!");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}
