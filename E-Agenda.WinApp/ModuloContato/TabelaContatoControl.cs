using E_Agenda.Dominio.ModuloContato;

namespace E_Agenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "E-mail", HeaderText = "E-mail"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Cargo", HeaderText = "Cargo"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Empresa", HeaderText = "Empresa"}
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
                    contato.informacoesPessoais.telefone, contato.informacoesPessoais.email,
                    contato.cargo,contato.empresa);
            }
        }
    }
}
