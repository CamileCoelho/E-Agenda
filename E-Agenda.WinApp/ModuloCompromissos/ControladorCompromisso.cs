using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso repositorioCompromisso;
        private listaCompromisso listagemCompromisso;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso)
        {
            this.repositorioCompromisso = repositorioCompromisso;
        }

        public override string ToolTipInserir { get { return "Inserir novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar Compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso existente"; } }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }
        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.ListarTodos();

            listagemCompromisso.AtualizarRegistros(compromissos);
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            throw new NotImplementedException();
        }
    }
}
