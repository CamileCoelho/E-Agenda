using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public class Compromisso : EntidadeBase
    {
        public string assunto { get; set; }
        public DateTime data { get; set; }
        public DateTime inicio { get; set; }
        public DateTime termino { get; set; }
        public string localizacao { get; set; }
        public Contato contato { get; set; }

        public Compromisso(string assunto, DateTime data, DateTime inicio, DateTime termino, string localizacao)
        {
            this.assunto = assunto;
            this.data = data;   
            this.inicio = inicio;   
            this.termino = termino;
            this.localizacao = localizacao;
        }

        public Compromisso(string assunto, DateTime data, DateTime inicio, DateTime termino, string localizacao, Contato contato)
        {
            this.assunto = assunto;
            this.data = data;
            this.inicio = inicio;
            this.termino = termino;
            this.localizacao = localizacao;
            this.contato = contato;
        }

        public override string ToString()
        {
            string contatoString = contato == null ?
                " - Sem Contato" : ", Contato: " + contato.informacoesPessoais.nome;
            return "Id: " + id + ", Assunto: " + assunto + ", Local: " + localizacao +
                ", Data: " + data.ToString() + ", Hora Início: " + inicio.ToString("HH:mm") +
                ", Hora Término: " + termino.ToString("HH:mm") + contato;
        }
    }
}
