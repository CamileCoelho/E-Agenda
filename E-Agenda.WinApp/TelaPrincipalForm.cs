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
        }

        private void PopularRepositoriosParaTeste()
        {
            InformacoesPessoais info1 = new("Camile", "(99) 99901-0780", "camile@gmail.com");
            InformacoesPessoais info2 = new("Tales", "(99) 99999-9999", "tales@gmail.com");
            InformacoesPessoais info3 = new("Rech", "(99) 99999-9999", "rech@gmail.com");
            InformacoesPessoais info4 = new("Tiago", "(99) 99999-9999", "tiago@gmail.com");

            Contato camile = new Contato(info1, "Dev", "NDD");
            Contato tales = new Contato(info2, "Dev", "NDD");
            Contato rech = new Contato(info3, "Dev", "ACAD. DO PROGAMADOR");
            Contato tiago = new Contato(info4, "Dev", "ACAD. DO PROGAMADOR");

            repositorioContato.Inserir(camile);
            repositorioContato.Inserir(tales);
            repositorioContato.Inserir(rech);
            repositorioContato.Inserir(tiago);

            Compromisso c01 = new("Entrevista", new DateOnly(2023, 05, 12), new TimeOnly(10, 00), new TimeOnly(11, 30), camile, "NDD", TipoLocalizacaoCompromissoEnum.Presencial);
            Compromisso c02 = new("Reuni�o", new DateOnly(2023, 05, 16), new TimeOnly(13, 00), new TimeOnly(14, 00), tales, "NDD", TipoLocalizacaoCompromissoEnum.Online);
            Compromisso c03 = new("Entrevista", new DateOnly(2023, 05, 18), new TimeOnly(15, 00), new TimeOnly(16, 30), rech, "MID", TipoLocalizacaoCompromissoEnum.Presencial);
            Compromisso c04 = new("Reuni�o", new DateOnly(2023, 05, 20), new TimeOnly(11, 00), new TimeOnly(12, 00), tiago, "NDD", TipoLocalizacaoCompromissoEnum.Online);

            repositorioCompromisso.Inserir(c01);
            repositorioCompromisso.Inserir(c02);
            repositorioCompromisso.Inserir(c03);
            repositorioCompromisso.Inserir(c04);

            Tarefa t1 = new("Tarefa 1", TipoPrioridadeTarefaEnum.Alta, new DateTime(2023, 05, 25));
            Tarefa t2 = new("Tarefa 2", TipoPrioridadeTarefaEnum.Baixa, new DateTime(2023, 05, 26));
            Tarefa t3 = new("Tarefa 3", TipoPrioridadeTarefaEnum.Alta, new DateTime(2023, 05, 27));
            Tarefa t4 = new("Tarefa 4", TipoPrioridadeTarefaEnum.Normal, new DateTime(2023, 05, 28));

            repositorioTarefa.Inserir(t1);
            repositorioTarefa.Inserir(t2);
            repositorioTarefa.Inserir(t3);
            repositorioTarefa.Inserir(t4);
        }

        public static TelaPrincipalForm Tela
        {
            get;
            private set;
        }

        public void AtualizarRodape(string status)
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
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnAdicionarItens.ToolTipText = controlador.ToolTipAdicionarItens;
            btnConcluirItens.ToolTipText = controlador.ToolTipConcluirItens;

            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionarItens.Enabled = controlador.AdicionarItensHabilitado;
            btnConcluirItens.Enabled = controlador.ConcluirItensHabilitado;
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

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            controlador.AdicionarItens();
        }

        private void btnConcluirItens_Click(object sender, EventArgs e)
        {
            controlador.ConcluirItens();
        }
    }
}