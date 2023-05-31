using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorio<Tarefa>
    {
        List<Tarefa> SelecionarConcluidas();
        List<Tarefa> SelecionarPendentes();
        List<Tarefa> SelecionarTodosOrdenadosPorPrioridade();
    }
}
