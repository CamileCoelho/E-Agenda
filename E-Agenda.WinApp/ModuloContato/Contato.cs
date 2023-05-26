using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase<Contato>
    {
        public InformacoesPessoais informacoesPessoais {  get; set; }
        public string cargo { get; set; }
        public string empresa { get; set; }

        public Contato(InformacoesPessoais informacoesPessoais, string cargo, string empresa)
        {
            this.informacoesPessoais = informacoesPessoais;
            this.cargo = cargo;
            this.empresa = empresa;
        }

        public override void AtualizarInformacoes(Contato registroAtualizado)
        {
            this.informacoesPessoais.nome = registroAtualizado.informacoesPessoais.nome;
            this.informacoesPessoais.telefone = registroAtualizado.informacoesPessoais.telefone;
            this.informacoesPessoais.email = registroAtualizado.informacoesPessoais.email;
            this.cargo = registroAtualizado.cargo;
            this.empresa = registroAtualizado.empresa;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(informacoesPessoais.nome))
                return $"Você deve escrever um nome!";

            if (informacoesPessoais.telefone == null || valida.ValidaTelefone(informacoesPessoais.telefone))
                return $"O telefone deve ser no formato (XX)XXXXX-XXXX";

            if (informacoesPessoais.email == null || valida.ValidaFormatoEmail(informacoesPessoais.email))
                return $"O e-mail deve ser no formato xxxxxx@xxxxx.xxx";

            return "";
        }

        public override string ToString()
        {
            return informacoesPessoais.nome;
        }
    }
}
