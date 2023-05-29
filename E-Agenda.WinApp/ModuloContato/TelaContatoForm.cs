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

        //public Contato ObterContato
        //{
        //    set
        //    {
        //        txtId.Text = value.id.ToString();
        //        txtNome.Text = value.informacoesPessoais.nome;
        //        txtTelefone.Text = value.informacoesPessoais.telefone.ToString();
        //        txtEmail.Text = value.informacoesPessoais.email;
        //        txtCargo.Text = value.cargo;
        //        txtEmpresa.Text = value.empresa;
        //    }
        //    get
        //    {
        //        return contato;
        //    }
        //}

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
    }
}
