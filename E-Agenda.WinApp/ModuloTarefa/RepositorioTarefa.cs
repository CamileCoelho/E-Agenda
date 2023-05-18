using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public void Editar(Tarefa tarefa)
        {
            Tarefa tarefaSelecionada = (Tarefa)SelecionarPorId(tarefa.id);

            tarefaSelecionada.titulo = tarefa.titulo;
            tarefaSelecionada.descricao = tarefa.descricao;
            tarefaSelecionada.prioridade = tarefa.prioridade;
        }
    }
}
