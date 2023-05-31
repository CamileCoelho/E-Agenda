namespace E_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioCategoria : RepositorioBase<Categoria>
    {
        public RepositorioCategoria(List<Categoria> categorias)
        {
            this.listaObjeto = categorias;
        }
    }
}
