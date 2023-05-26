using E_Agenda.WinApp.Compartilhado;
using System.Windows.Forms;

namespace E_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato { get; set; }

        public TelaContatoForm()
        {
            InitializeComponent();
        }

        public Contato ObterContato
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.informacoesPessoais.nome;
                txtTelefone.Text = value.informacoesPessoais.telefone.ToString();
                txtEmail.Text = value.informacoesPessoais.email;
                txtCargo.Text = value.cargo;
                txtEmpresa.Text = value.empresa;
            }
            get
            {
                return contato;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string email = txtEmail.Text;

            string cargo = txtCargo.Text;

            string empresa = txtEmpresa.Text;

            InformacoesPessoais info = new(nome, telefone, email);

            contato = new(info, cargo, empresa);

            string status = contato.Validar();

            if (status != "")
            {
                TelaPrincipalForm.Tela.atualizarRodape(status);

                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                contato.id = Convert.ToInt32(txtId.Text);
        }
    }
}
