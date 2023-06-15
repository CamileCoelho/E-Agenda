using E_Agenda.Dominio.ModuloContato;

namespace E_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private IRepositorioContato repositorioContato;
        private TabelaContatoControl listagemContato;

        public ControladorContato(IRepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo contato"; } }

        public override string ToolTipEditar { get { return "Editar contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir contato existente"; } }

        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;

        public override void Inserir()
        {
            TelaContatoForm telaContato = new();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.ObterContato();

                repositorioContato.Inserir(contato);

                CarregarContatos();
            }
        }

        public override void Editar()
        {
            Contato contatoSelecionado = ObterContatoSelecionado();

            if (contatoSelecionado == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaContatoForm tela = new();

            tela.ConfigurarTela(contatoSelecionado);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = tela.ObterContato();

                repositorioContato.Editar(contatoSelecionado, contato);

                CarregarContatos();
            }
        }

        public override void Excluir()
        {
            Contato contato = ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.informacoesPessoais.nome}?", "Exclusão de Contatos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Excluir(contato);

                CarregarContatos();
            }
        }
        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listagemContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if (listagemContato == null)
                listagemContato = new TabelaContatoControl();

            CarregarContatos();

            return listagemContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        private Contato ObterContatoSelecionado()
        {
            int id = listagemContato.ObterNumeroContatoSelecionado();

            return repositorioContato.SelecionarPorId(id);
        }
    }
}
