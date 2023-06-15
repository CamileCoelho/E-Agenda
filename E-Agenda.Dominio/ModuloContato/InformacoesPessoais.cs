namespace E_Agenda.Dominio.Compartilhado
{
    [Serializable]
    public class InformacoesPessoais 
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public InformacoesPessoais()
        {
            
        }

        public InformacoesPessoais(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }        
    }
}
