using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase
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

        public string validar()
        {
            Validador valida = new();

            if (valida.ValidarString(informacoesPessoais.nome))
                return $"Você deve escrever um nome!";

            if (informacoesPessoais.telefone == null || valida.ValidaTelefone(informacoesPessoais.telefone))
                return $"O telefone deve ser no formato (XX)XXXXX-XXXX";

            if (informacoesPessoais.email == null || valida.ValidaFormatoEmail(informacoesPessoais.email))
                return $"O e-mail deve ser no formato xxxxxx@xxxxx.xxx";

            return "";
        }
    }
}
