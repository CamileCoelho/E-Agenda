using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloCompromissos;
using E_Agenda.WinApp.ModuloContato;
using E_Agenda.WinApp.ModuloTarefa;

namespace E_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioTarefa repositorioTarefa = new();
        private RepositorioContato repositorioContato = new();
        private RepositorioCompromisso repositorioCompromisso = new();

        public TelaPrincipalForm()
        {
            InitializeComponent();

            Tela = this;

            PopularRepositoriosParaTeste();
            lableRodape.Text = string.Empty;
            labelTipoDoCadastro.Text = string.Empty;
            //desabilitar os botoes de add,edit e del
        }

        private void PopularRepositoriosParaTeste()
        {
            InformacoesPessoais info1 = new("Camile", "(99) 99901-0780", "camile@gmail.com");
            InformacoesPessoais info2 = new("Tales", "(99) 99999-9999", "tales@gmail.com");
            InformacoesPessoais info3 = new("Rech", "(99) 99999-9999", "rech@gmail.com");
            InformacoesPessoais info4 = new("Tiago", "(99) 99999-9999", "tiago@gmail.com");

            Contato camile = new Contato(info1, "Dev", "NDD");
            
            Contato tales = new Contato(info1, "Dev", "NDD");

            Contato rech = new Contato(info3, "Dev", "ACAD. DO PROGAMADOR");

            Contato tiago = new Contato(info4, "Dev", "ACAD. DO PROGAMADOR");

            repositorioContato.Inserir(camile);
            repositorioContato.Inserir(tales);
            repositorioContato.Inserir(rech);
            repositorioContato.Inserir(tiago);

            //Compromisso c01 = new Compromisso();
            //Compromisso c02 = new Compromisso();
            //Compromisso c03 = new Compromisso();
            //Compromisso c04 = new Compromisso();
            //Compromisso c05 = new Compromisso();

            //repositorioCompromisso.Inserir(c01);
            //repositorioCompromisso.Inserir(c02);
            //repositorioCompromisso.Inserir(c03);
            //repositorioCompromisso.Inserir(c04);
            //repositorioCompromisso.Inserir(c05);
        }

        public static TelaPrincipalForm Tela
        {
            get;
            private set;
        }

        public void atualizarRodape(string status)
        {
            lableRodape.Text = status;
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }
        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioContato, repositorioCompromisso);

            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoDoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }
    }
}