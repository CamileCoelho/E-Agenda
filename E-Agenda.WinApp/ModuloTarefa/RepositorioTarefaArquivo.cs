using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefaArquivo : RepositorioBaseArquivoJson<Tarefa>, IRepositorioTarefa
    {
        public List<Tarefa> SelecionarConcluidas()
        {
            return listaGeral
                    .Where(x => x.percentualConcluido == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return listaGeral
                    .Where(x => x.percentualConcluido < 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return listaGeral
                    .OrderByDescending(x => x.prioridade)
                    .ToList();
        }
    }
}
