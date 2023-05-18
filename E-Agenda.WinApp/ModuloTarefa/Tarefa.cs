using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string prioridade { get; set; }

        public Tarefa(string titulo, string descricao, string prioridade)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.prioridade = prioridade;
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + titulo + " Descição: " + descricao + " Prioridade: " + prioridade;
        }
    }
}
