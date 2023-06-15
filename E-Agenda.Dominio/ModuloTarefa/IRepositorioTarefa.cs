namespace E_Agenda.Dominio.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorio<Tarefa>
    {
        List<Tarefa> SelecionarConcluidas();
        List<Tarefa> SelecionarPendentes();
        List<Tarefa> SelecionarTodosOrdenadosPorPrioridade();
    }
}
