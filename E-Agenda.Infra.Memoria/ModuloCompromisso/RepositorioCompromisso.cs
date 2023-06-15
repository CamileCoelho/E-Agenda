using E_Agenda.Dominio.ModuloCompromissos;

namespace E_Agenda.Infra.Dados.Memoria.ModuloCompromissos
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso()
        {
            
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateOnly hoje)
        {
            return listaObjeto.Where(x => x.data.Day < hoje.Day).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateOnly dataInicio, DateOnly dataFinal)
        {
            return listaObjeto
                .Where(x => x.data > dataInicio.ToDateTime(TimeOnly.MinValue))
                .Where(x => x.data < dataFinal.ToDateTime(TimeOnly.MinValue))
                .ToList();
        }
    }
}
