using E_Agenda.Dominio.ModuloTarefa;

namespace E_Agenda.Infra.Dados.Arquivo.ModuloTarefa
{
    public class RepositorioTarefaArquivo : RepositorioBaseArquivo<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return ObterRegistros()
                    .Where(x => x.percentualConcluido == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return ObterRegistros()
                    .Where(x => x.percentualConcluido < 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return ObterRegistros()
                    .OrderByDescending(x => x.prioridade)
                    .ToList();
        }

        protected override List<Tarefa> ObterRegistros()
        {
            return contextoDeDados.tarefas;
        }
    }
}
