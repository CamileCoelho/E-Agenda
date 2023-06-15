using E_Agenda.Dominio.ModuloCompromissos;

namespace E_Agenda.Dominio.ModuloTarefa
{
    [Serializable]
    public class Tarefa : EntidadeBase<Tarefa>
    {
        public string titulo { get; set; }
        public TipoPrioridadeTarefaEnum prioridade { get; set; }
        public DateTime dataCriacao { get; set; }
        public List<ItemTarefa> itens { get; set; }
        public decimal percentualConcluido { get; set; }

        public Tarefa()
        { 

        }

        public Tarefa(string titulo, TipoPrioridadeTarefaEnum prioridade, DateTime dataCriacao)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            this.itens = new List<ItemTarefa>();
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

            if (valida.ValidaEnum(prioridade) || prioridade == TipoPrioridadeTarefaEnum.Nenhuma)
                return $"Você deve selecionar a prioridade!";

            if (valida.ValidaDateTime(dataCriacao))
                return $"Você deve selecionar a data de criação!";

            return "";
        }

        public void AdicionarItem(ItemTarefa item)
        {
            if (itens.Contains(item))
                return;

            itens.Add(item);

            CalcularPercentualConcluido();
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemSelecionado = itens.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Concluir();

            CalcularPercentualConcluido();
        }

        public void DesmarcarItem(ItemTarefa item)
        {
            ItemTarefa itemSelecionado = itens.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Desmarcar();

            CalcularPercentualConcluido();
        }

        private void CalcularPercentualConcluido()
        {
            decimal qtdItens = itens.Count();

            if (qtdItens == 0)
                return;

            decimal qtdConcluidos = itens.Count(x => x.concluido == true);

            decimal resultado = (qtdConcluidos / qtdItens) * 100;

            percentualConcluido = Math.Round(resultado, 2);
        }
    }
}
