using E_Agenda.Dominio.ModuloDespesas;

namespace E_Agenda.WinApp.ModuloDespesas
{
    public partial class TabelaCategoriaControl : UserControl
    {
        public TabelaCategoriaControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo"}
            };

            return colunas;
        }

        public int ObterNumeroCategoriaSelecionada()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Categoria> categorias)
        {
            grid.Rows.Clear();

            foreach (var categoria in categorias)
            {
                grid.Rows.Add(categoria.id, categoria.titulo);
            }
        }
    }
}
