namespace E_Agenda.WinApp.ModuloDespesas
{
    public class Despesa : EntidadeBase<Despesa>
    {
        public string descricao { get; set; }
        public DateTime data { get; set; }
        public decimal valor { get; set; }
        public TipoPgtoDespesaEnum formaPgto { get; set; }
        public List<Categoria> categorias { get; set; }

        public Despesa()
        {
            
        }

        public Despesa(string descricao, DateTime data, decimal valor, TipoPgtoDespesaEnum formaPgto)
        {
            this.descricao = descricao;
            this.data = data;
            this.valor = valor;
            this.formaPgto = formaPgto;
            categorias = new List<Categoria>();
        }

        public override void AtualizarInformacoes(Despesa registroAtualizado)
        {
            descricao = registroAtualizado.descricao;
            data = registroAtualizado.data;
            valor = registroAtualizado.valor;
            formaPgto = registroAtualizado.formaPgto;
            categorias = registroAtualizado.categorias;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(descricao))
                return $"Você deve escrever uma descrição!";

            if (valida.ValidaDateTime(data))
                return $"O campo 'data' é obrigatório!";

            if (valor <= 0)
                return $"O valor deve ser maior que zero!";

            if (valida.ValidaEnum(formaPgto) || formaPgto == TipoPgtoDespesaEnum.Nenhum)
                return $"Você deve selecionar uma forma de pagamento!";

            return "";
        }
    }
}
