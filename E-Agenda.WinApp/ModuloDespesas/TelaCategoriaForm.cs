using E_Agenda.WinApp.ModuloDespesas;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaCategoriaForm : Form
    {
        public TelaCategoriaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Categoria ObterCategoria()
        {
            int id = Convert.ToInt32(txtId.Text);

            string titulo = txtTitulo.Text;

            return new Categoria(id, titulo);
        }

        public void ConfigurarTela(Categoria categoria)
        {
            txtId.Text = categoria.id.ToString();

            txtTitulo.Text = categoria.titulo;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Categoria categoria = ObterCategoria();

            string status = categoria.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
            {
                DialogResult = DialogResult.None;
            }
        }
    }
}
