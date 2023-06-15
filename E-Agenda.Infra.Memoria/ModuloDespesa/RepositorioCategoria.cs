using E_Agenda.Dominio.ModuloDespesas;

namespace E_Agenda.Infra.Dados.Memoria.ModuloDespesas
{
    public class RepositorioCategoria : RepositorioBase<Categoria>
    {
        public RepositorioCategoria(List<Categoria> categorias)
        {
            this.listaObjeto = categorias;
        }
    }
}
