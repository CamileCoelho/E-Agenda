namespace E_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<T> where T : EntidadeBase<T>
    {
        protected List<T> listaObjeto = new();

        protected int idContador = 0;

        public virtual void Inserir(T adicionar)
        {
            adicionar.id = idContador++;
            listaObjeto.Add(adicionar);
        }

        public virtual void Editar(T registroSelecionado, T registroAtualizado)
        {
            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Editar(int id, T registroAtualizado)
        {
            T registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Excluir(int id)
        {
            T registroSelecionado = SelecionarPorId(id);

            if (registroSelecionado != null)
                listaObjeto.Remove(registroSelecionado);
        }

        public virtual void Excluir(T apagar)
        {
            listaObjeto.Remove(apagar);
        }

        public virtual List<T> ListarTodos()
        {
            return listaObjeto;
        }

        public virtual T SelecionarPorId(int id)
        {
            return listaObjeto.Find(entidade => entidade.id == id);
        }

        //public virtual T SelecionarPorId(int id)
        //{
        //    if (listaObjeto.Exists(registro => registro.id == id))
        //        return listaObjeto.First(registro => registro.id == id);

        //    return null;
        //}

        public virtual List<T> SelecionarTodos()
        {
            return listaObjeto.OrderByDescending(x => x.id).ToList();
        }
    }
}
