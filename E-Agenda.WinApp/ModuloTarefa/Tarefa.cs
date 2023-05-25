using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloCompromissos;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>
    {
        public string titulo { get; set; }
        public TipoPrioridadeTarefaEnum prioridade { get; set; }
        public DateTime dataCriacao { get; set; }
        public List<ItemTarefa> itens { get; set; }
        public decimal percentualConcluido { get; set; }

        public Tarefa(string titulo, TipoPrioridadeTarefaEnum prioridade)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
        }

        public override void AtualizarInformacoes(Tarefa registroAtualizado)
        {
            this.titulo = registroAtualizado.titulo;
            this.prioridade = registroAtualizado.prioridade;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(titulo))
                return $"Você deve escrever um título!";

            if (valida.ValidaEnum(prioridade))
                return $"Você deve selecionar a prioridade!";

            return "";
        }
    }
}
