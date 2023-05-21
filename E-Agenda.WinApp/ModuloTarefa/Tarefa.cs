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
        public string validar()
        {
            Validador valida = new();

            if (valida.ValidarString(titulo))
                return $"Você deve escrever um título!";

            if (valida.ValidarString(descricao))
                return $"Você deve escrever uma descrição!";

            if (valida.ValidarString(prioridade))
                return $"Você deve selecionar a prioridade!";

            return "";
        }
    }
}
