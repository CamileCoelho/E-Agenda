using E_Agenda.Dominio.ModuloTarefa;

namespace E_Agenda.Infra.Dados.Arquivo.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public RepositorioTarefa()
        {
            
        }

        public List<Tarefa>? SelecionarConcluidas()
        {
            return listaObjeto
                .Where(x => x.percentualConcluido == 100)
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        public List<Tarefa>? SelecionarPendentes()
        {
            return listaObjeto
                .Where(x => x.percentualConcluido < 100)
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return listaObjeto
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }
    }
}
