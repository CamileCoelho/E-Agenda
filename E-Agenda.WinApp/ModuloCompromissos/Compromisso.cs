using E_Agenda.WinApp.ModuloContato;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    [Serializable]
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public string assunto { get; set; }
        public DateTime data { get; set; }
        public DateTime horarioInicio { get; set; }
        public DateTime horarioTermino { get; set; }
        public string localizacao { get; set; }
        public TipoLocalizacaoCompromissoEnum tipoLocal { get; set; }
        public Contato contato { get; set; }

        public Compromisso()
        {
            
        }

        public Compromisso(string assunto, DateOnly data, TimeOnly horarioInicio, 
        TimeOnly horarioTermino, Contato contato, string localizacao, 
        TipoLocalizacaoCompromissoEnum tipo)
        {
            this.assunto = assunto;
            this.data = data.ToDateTime(TimeOnly.MinValue);
            this.horarioInicio = data.ToDateTime(horarioInicio);
            this.horarioTermino= data.ToDateTime(horarioTermino);
            this.contato = contato;
            tipoLocal = tipo;

            if (tipoLocal == TipoLocalizacaoCompromissoEnum.Online)
                this.localizacao = localizacao;

            if (tipoLocal == TipoLocalizacaoCompromissoEnum.Presencial)
                this.localizacao = localizacao;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(assunto))
                return $"O campo de assunto não pode estar vazio!";

            if (valida.ValidaDateTime(data))
                return $"Você deve adicionar uma data!";

            if (valida.ValidaDateTimeComTimeOnly(horarioInicio))
                return $"Você deve adicionar o horario de início!";

            if (valida.ValidaDateTimeComTimeOnly(horarioTermino))
                return $"Você deve adicionar o horario de término!";

            if (horarioTermino <= horarioInicio)
                return $"O horario de término deve ser posterior ao horário de início!";

            if (tipoLocal == TipoLocalizacaoCompromissoEnum.Nenhum)
                return $"Você deve selecionar uma das opções de localização!";

            if (tipoLocal == TipoLocalizacaoCompromissoEnum.Online && valida.ValidaString(localizacao))
                return $"O campo do local online não pode estar vazio!";

            if (tipoLocal == TipoLocalizacaoCompromissoEnum.Presencial && valida.ValidaString(localizacao))
                return $"O campo do local presencial não pode estar vazio!";

            return "";
        }

        public override void AtualizarInformacoes(Compromisso registroAtualizado)
        {
            assunto = registroAtualizado.assunto;
            data = registroAtualizado.data;
            horarioInicio = registroAtualizado.horarioInicio;
            horarioTermino = registroAtualizado.horarioTermino;
            localizacao = registroAtualizado.localizacao;
            contato = registroAtualizado.contato;
        }
    }
}
