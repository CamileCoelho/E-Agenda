namespace E_Agenda.WinApp.ModuloDespesas
{
    public class Categoria : EntidadeBase<Categoria>
    {
        public string titulo;

        public List<Despesa> despesas;

        public Categoria()
        {
            
        }

        public Categoria(string titulo)
        {
            this.titulo = titulo;
            despesas = new List<Despesa>();    
        }

        public Categoria(int id, string titulo)
        {
            this.id = id;
            this.titulo = titulo;
            despesas = new List<Despesa>();
        }

        public override void AtualizarInformacoes(Categoria registroAtualizado)
        {
            titulo = registroAtualizado.titulo;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(titulo))
                return $"Você deve escrever um título!";

            return "";
        }
    }
}
