using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public class Compromisso : EntidadeBase
    {
        public string assunto { get; set; }
        public DateTime data { get; set; }
        public DateTime horarioInicio { get; set; }
        public DateTime horarioTermino { get; set; }
        public string localizacao { get; set; }
        public string localPresencial { get; set; }
        public string localOnline { get; set; }
        public TipoLocalizacaoCompromissoEnum tipoLocal { get; set; }
        public Contato contato { get; set; }

        public Compromisso(string assunto, DateTime data, DateTime horarioInicio, 
            DateTime horarioTermino, Contato contato, string localizacao, 
            TipoLocalizacaoCompromissoEnum tipo)
        {
            this.assunto = assunto;
            this.data = data;
            this.horarioInicio = horarioInicio;
            this.horarioTermino= horarioTermino;
            this.contato = contato;
            this.tipoLocal = tipoLocal;

            if (tipoLocal == TipoLocalizacaoCompromissoEnum.Online)
                this.localOnline = localizacao;
            else
                this.localPresencial = localizacao;
        }

        public Compromisso(string assunto, DateTime data, DateTime inicio, DateTime termino, string localizacao, TipoLocalizacaoCompromissoEnum tipoLocal, Contato contato)
        {
            this.assunto = assunto;
            this.data = data;   
            this.horarioInicio = inicio;   
            this.horarioTermino = termino;
            this.tipoLocal = tipoLocal;
            this.contato = contato;

            if (tipoLocal == TipoLocalizacaoCompromissoEnum.Online)
            {
                this.localOnline = localizacao;
            }
            else
            {
                this.localPresencial = localizacao;
            }
        }

        public string validar()
        {
            Validador valida = new();

            if (valida.ValidarString(assunto))
                return $"O campo de assunto não pode estar vazio!";

            if (valida.ValidaDateTime(data))
                return $"Você deve adicionar uma data!";

            if (valida.ValidaDateTime(horarioInicio))
                return $"Você deve adicionar o horario de início!";

            if (valida.ValidaDateTime(horarioTermino))
                return $"Você deve adicionar o horario de término!";

            return "";
        }
    }
}
