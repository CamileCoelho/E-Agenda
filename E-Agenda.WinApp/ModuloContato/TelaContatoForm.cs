using E_Agenda.Dominio.ModuloContato;

namespace E_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato { get; set; }

        public TelaContatoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            contato = ObterContato();

            string status = contato.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
                DialogResult = DialogResult.None;
        }

        public Contato ObterContato()
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;

            InformacoesPessoais info = new(nome, telefone, email);

            return new(info, cargo, empresa);
        }

        public void ConfigurarTela(Contato contatoSelecionado)
        {
            txtId.Text = contatoSelecionado.id.ToString();
            txtNome.Text = contatoSelecionado.informacoesPessoais.nome;
            txtTelefone.Text = contatoSelecionado.informacoesPessoais.telefone.ToString();
            txtEmail.Text = contatoSelecionado.informacoesPessoais.email;
            txtCargo.Text = contatoSelecionado.cargo;
            txtEmpresa.Text = contatoSelecionado.empresa;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}
