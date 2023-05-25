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

        ////Selecionar Compromissos Passados
        //public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
        //{
        //    return listaObjeto.Where(x => x.data.Date < hoje.Date).ToList();
        //}

        ////Selecionar Compromissos Futuros ( dataInicio, dataFinal)
        //public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        //{
        //    return listaObjeto
        //        .Where(x => x.data > dataInicio)
        //        .Where(x => x.data < dataFinal)
        //        .ToList();
        //}
    }
}
