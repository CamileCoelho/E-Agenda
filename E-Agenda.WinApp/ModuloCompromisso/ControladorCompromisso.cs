using E_Agenda.Dominio.ModuloCompromissos;
using E_Agenda.Dominio.ModuloContato;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public class ControladorCompromisso : ControladorBase
    {
        private IRepositorioCompromisso repositorioCompromisso;
        private IRepositorioContato repositorioContato;
        private TabelaCompromissoControl listagemCompromisso;

        public ControladorCompromisso(IRepositorioContato repositorioContato, IRepositorioCompromisso repositorioCompromisso)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir => "Inserir novo compromisso";

        public override string ToolTipEditar => "Editar compromisso existente";

        public override string ToolTipExcluir => "Excluir compromisso existente";

        public override string ToolTipFiltrar => "Filtrar compromissos";

        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;
        public override bool FiltrarHabilitado => true;

        public override void Inserir()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            TelaCompromissoForm tela = new(contatos);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = tela.ObterCompromisso();

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();
            }
        }
        public override void Editar()
        {
            Compromisso compromissoSelecionado = ObterCompromissoSelecionado();

            if (compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Edição de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Contato> contatos = repositorioContato.SelecionarTodos();
            TelaCompromissoForm tela = new(contatos);

            tela.ConfigurarTela(compromissoSelecionado);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = tela.ObterCompromisso();

                repositorioCompromisso.Editar(compromissoSelecionado, compromisso);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {
            Compromisso compromisso = ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Exclusão de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o compromisso {compromisso.assunto}?", "Exclusão de Compromissos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Filtrar()
        {
            TelaFiltroCompromissoForm telaFiltro = new();
            DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                StatusCompromissoEnum status = telaFiltro.ObterStatus();
                List<Compromisso> compromissos = null;

                if (status == StatusCompromissoEnum.Todos)
                {
                    compromissos = repositorioCompromisso.SelecionarTodos();
                }

                else if (status == StatusCompromissoEnum.Passados)
                {
                    compromissos = repositorioCompromisso.SelecionarCompromissosPassados(DateOnly.FromDateTime(DateTime.Today));
                }
                else if (status == StatusCompromissoEnum.Futuros)
                {
                    DateOnly dataInicio = DateOnly.FromDateTime(telaFiltro.ObterDataInicio());
                    DateOnly dataFinal = DateOnly.FromDateTime(telaFiltro.ObterDataFinal());

                    compromissos = repositorioCompromisso.SelecionarCompromissosFuturos(dataInicio, dataFinal);
                }

                CarregarCompromissos();

                TelaPrincipalForm.Tela.AtualizarRodape($"Visualizando {compromissos.Count} compromissos");
            }
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listagemCompromisso.AtualizarRegistros(compromissos);
        }

        public override UserControl ObterListagem()
        {
            if (listagemCompromisso == null)
                listagemCompromisso = new TabelaCompromissoControl();

            CarregarCompromissos();

            return listagemCompromisso;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }

        public Compromisso ObterCompromissoSelecionado()
        {
            int id = listagemCompromisso.ObterNumeroCompromissoSelecionado();

            return repositorioCompromisso.SelecionarPorId(id);
        }
    }
}
