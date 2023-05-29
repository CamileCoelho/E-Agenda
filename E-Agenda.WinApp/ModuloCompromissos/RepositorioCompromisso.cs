using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso()
        {
            
        }

        public RepositorioCompromisso(List<Compromisso> compromissos)
        {
            this.listaObjeto = compromissos;
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateOnly hoje)
        {
            return listaObjeto.Where(x => x.data.Day < hoje.Day).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateOnly dataInicio, DateOnly dataFinal)
        {
            return listaObjeto
                .Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList();
        }
    }
}
