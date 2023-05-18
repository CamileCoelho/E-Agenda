namespace E_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<T> where T : EntidadeBase
    {
        protected List<T> listaObjeto = new List<T>();

        protected int idcontador = 1;

        public virtual void Inserir(T adicionar)
        {
            adicionar.id = idcontador++;
            listaObjeto.Add(adicionar);
        }

        public virtual EntidadeBase SelecionarPorId(int id)
        {
            return listaObjeto.Find(entidade => entidade.id == id);
        }

        public virtual List<T> ListarTodos()
        {
            return listaObjeto;
        }

        public virtual void Excluir(T apagar)
        {
            listaObjeto.Remove(apagar);
        }
    }
}
