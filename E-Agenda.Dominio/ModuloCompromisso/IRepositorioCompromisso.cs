namespace E_Agenda.Dominio.ModuloCompromissos
{
    public interface IRepositorioCompromisso : IRepositorio<Compromisso>
    {
        List<Compromisso> SelecionarCompromissosPassados(DateOnly hoje);
        List<Compromisso> SelecionarCompromissosFuturos(DateOnly dataInicio, DateOnly dataFinal);
    }
}
