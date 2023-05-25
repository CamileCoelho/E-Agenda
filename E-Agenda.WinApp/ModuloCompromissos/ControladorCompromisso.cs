using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;
using E_Agenda.WinApp.ModuloTarefa;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioBase<Compromisso> repositorioBaseCompromisso;
        private RepositorioCompromisso repositorioCompromisso;
        private RepositorioContato repositorioContato;
        private TabelaCompromissoControl listagemCompromisso;

        public ControladorCompromisso(RepositorioContato repositorioContato, RepositorioCompromisso repositorioCompromisso)
        {
            repositorioBaseCompromisso = repositorioCompromisso;
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir => "Inserir novo compromisso";

        public override string ToolTipEditar => "Editar compromisso existente";

        public override string ToolTipExcluir => "Excluir compromisso existente";

        public override string ToolTipFiltrar => "Filtrar compromissos";

        public override bool FiltrarHabilitado => true;

        public override void Inserir()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            TelaCompromissoForm tela = new(contatos);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = tela.ObterCompromisso();

                repositorioBaseCompromisso.Inserir(compromisso);

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

                //repositorioCompromisso.Editar(compromissoSelecionado, compromisso);

                repositorioCompromisso.Editar(compromisso.id, compromisso);

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
                repositorioBaseCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Filtrar()
        {
            TelaFiltroCompromissoForm telaFiltro = new();
            DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

            //if (opcaoEscolhida == DialogResult.OK)
            //{
            //    StatusCompromissoEnum status = telaFiltro.ObterStatus();
            //    List<Compromisso> compromissos = null;

            //    if (status == StatusCompromissoEnum.Todos)
            //    {
            //        compromissos = repositorioCompromisso.SelecionarTodos();
            //    }

            //    else if (status == StatusCompromissoEnum.Passados)
            //    {
            //        compromissos = repositorioCompromisso.SelecionarCompromissosPassados(DateTime.Now);                    
            //    }
            //    else if (status == StatusCompromissoEnum.Futuros)
            //    {
            //        DateTime dataInicio = telaFiltro.ObterDataInicio();
            //        DateTime dataFinal = telaFiltro.ObterDataFinal();

            //        compromissos = repositorioCompromisso.SelecionarCompromissosFuturos(dataInicio, dataFinal);                    
            //    }

            //    CarregarCompromissos(compromissos);

            //    TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count} compromissos");
            //}
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.ListarTodos();

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

            return (Compromisso)repositorioBaseCompromisso.SelecionarPorId(id);
        }
    }
}
