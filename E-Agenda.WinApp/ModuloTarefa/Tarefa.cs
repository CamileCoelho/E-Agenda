using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {
        public string titulo { get; set; }
        public string prioridade { get; set; }

        public Tarefa(int id, string titulo, string prioridade)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + titulo + ", Prioridade: " + prioridade;
        }
    }
}
