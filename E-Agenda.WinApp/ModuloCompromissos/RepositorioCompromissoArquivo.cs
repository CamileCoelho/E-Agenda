namespace E_Agenda.WinApp.ModuloCompromissos
{
    public class RepositorioCompromissoArquivo : RepositorioBaseArquivo<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoArquivo(ContextoDeDados contexto) : base(contexto)
        {
            
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateOnly hoje)
        {
            return ObterRegistros().Where(x => x.data.Day < hoje.Day).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateOnly dataInicio, DateOnly dataFinal)
        {
            return ObterRegistros()
                .Where(x => x.data > dataInicio.ToDateTime(TimeOnly.MinValue))
                .Where(x => x.data < dataFinal.ToDateTime(TimeOnly.MinValue))
                .ToList();
        }

        protected override List<Compromisso> ObterRegistros()
        {
            return contextoDeDados.compromissos;
        }
    }
}
