using e_Agenda.WinApp.ModuloTarefa;
using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        RepositorioBase<Tarefa> repositorioBaseTarefa;
        RepositorioTarefa repositorioTarefa;
        TabelaTarefaControl listagemTarefa;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioBaseTarefa = repositorioTarefa;
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string ToolTipInserir { get { return "Inserir nova tarefa"; } }

        public override string ToolTipEditar { get { return "Editar tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluír tarefa existente"; } }

        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;
        public override bool FiltrarHabilitado => true;

        public override bool AdicionarItensHabilitado => true;

        public override bool ConcluirItensHabilitado => true;

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new(false);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Inserir(tarefa);

                CarregarTarefas();
            }
        }

        public override void Editar()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaForm tela = new(true);
            tarefaSelecionada = tela.ObterTarefa();

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = tela.ObterTarefa();
                
                repositorioTarefa.Editar(tarefaSelecionada, tarefa);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Exclusão de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefa.titulo}?", "Exclusão de Tarefas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefa);

                CarregarTarefas();
            }
        }

        public override void AdicionarItens()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Adição de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaCadastroItensTarefaForm telaCadastroItensTarefa = new TelaCadastroItensTarefaForm(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaCadastroItensTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensParaAdicionar = telaCadastroItensTarefa.ObterItensCadastrados();

                foreach (ItemTarefa item in itensParaAdicionar)
                {
                    tarefaSelecionada.AdicionarItem(item);
                }

                repositorioTarefa.Editar(tarefaSelecionada.id, tarefaSelecionada);
                CarregarTarefas();
            }
        }

        public override void ConcluirItens()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Atualização de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaAtualizacaoItensTarefaForm telaAtualizacaoItensTarefa = new TelaAtualizacaoItensTarefaForm(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaAtualizacaoItensTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensMarcados = telaAtualizacaoItensTarefa.ObterItensMarcados();

                List<ItemTarefa> itensPendentes = telaAtualizacaoItensTarefa.ObterItensPendentes();

                foreach (ItemTarefa item in itensMarcados)
                {
                    tarefaSelecionada.ConcluirItem(item);
                }

                foreach (ItemTarefa item in itensPendentes)
                {
                    tarefaSelecionada.DesmarcarItem(item);
                }

                repositorioTarefa.Editar(tarefaSelecionada.id, tarefaSelecionada);

                CarregarTarefas();
            }
        }

        public override void Filtrar()
        {
            TelaFiltroTarefaForm telaFiltroTarefa = new TelaFiltroTarefaForm();

            DialogResult opcaoEscolhida = telaFiltroTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<Tarefa> tarefas;

                StatusTarefaEnum status = telaFiltroTarefa.ObterFiltroTarefa();

                switch (status)
                {
                    case StatusTarefaEnum.Pendentes:
                        tarefas = repositorioTarefa.SelecionarPendentes();
                        break;

                    case StatusTarefaEnum.Concluidas:
                        tarefas = repositorioTarefa.SelecionarConcluidas();
                        break;

                    default:
                        tarefas = repositorioTarefa.SelecionarTodosOrdenadosPorPrioridade();
                        break;
                }

                CarregarTarefas(tarefas);
            }
        }

        private void CarregarTarefas(List<Tarefa> tarefas)
        {
            listagemTarefa.AtualizarRegistros(tarefas);

            TelaPrincipalForm.Tela.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s)!");
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodosOrdenadosPorPrioridade();

            listagemTarefa.AtualizarRegistros(tarefas);

            TelaPrincipalForm.Tela.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s)!");
        }

        public override UserControl ObterListagem()
        {
            if (listagemTarefa == null)
                listagemTarefa = new TabelaTarefaControl();

            CarregarTarefas();

            return listagemTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        private Tarefa ObterTarefaSelecionada()
        {
            int id = listagemTarefa.ObterNumeroTarefaSelecionada();

            return (Tarefa)repositorioBaseTarefa.SelecionarPorId(id);
        }
    }
}
