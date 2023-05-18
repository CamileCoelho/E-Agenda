using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public class Compromisso : EntidadeBase
    {
        public string assunto { get; set; }
        public string data { get; set; }
        public string inicio { get; set; }
        public string termino { get; set; }
        public string localizacao { get; set; }
        public Contato contato { get; set; }

        public Compromisso(string assunto, string data, string inicio, string termino, string localizacao)
        {
            this.assunto = assunto;
            this.data = data;   
            this.inicio = inicio;   
            this.termino = termino;
            this.localizacao = localizacao;
        }

        public Compromisso(string assunto, string data, string inicio, string termino, string localizacao, Contato contato)
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
            return "Id: " + id + ", " + assunto + ", Data: " + data + ", " +
                "\nHorário: Das" + inicio + " ás " + termino + ", Localização: " + localizacao;
        }
    }
}
