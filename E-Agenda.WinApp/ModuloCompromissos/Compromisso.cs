using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    [Serializable]
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public string assunto { get; set; }
        public DateOnly data { get; set; }
        public TimeOnly horarioInicio { get; set; }
        public TimeOnly horarioTermino { get; set; }
        public string localizacao { get; set; }
        public TipoLocalizacaoCompromissoEnum tipoLocal { get; set; }
        public Contato contato { get; set; }

        public Compromisso(string assunto, DateOnly data, TimeOnly horarioInicio, 
        TimeOnly horarioTermino, Contato contato, string localizacao, 
        TipoLocalizacaoCompromissoEnum tipo)
        {
            this.assunto = assunto;
            this.data = data;
            this.horarioInicio = horarioInicio;
            this.horarioTermino= horarioTermino;
            this.contato = contato;
            this.tipoLocal = tipo;

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

            if (valida.ValidaDateOnly(data))
                return $"Você deve adicionar uma data!";

            if (valida.ValidaTimeOnly(horarioInicio))
                return $"Você deve adicionar o horario de início!";

            if (valida.ValidaTimeOnly(horarioTermino))
                return $"Você deve adicionar o horario de término!";

            if (horarioTermino <= horarioInicio)
                return $"O horario de término deve ser posterior ao horário de início!";

            if (tipoLocal == TipoLocalizacaoCompromissoEnum.Nenhum)
                return $"Você deve selecionar uma das opções de localização!";

            if (tipoLocal == TipoLocalizacaoCompromissoEnum.Online)
            {
                if (valida.ValidaString(localizacao))
                    return $"O campo do local online não pode estar vazio!";
                else
                    return "";
            }
            if (tipoLocal == TipoLocalizacaoCompromissoEnum.Presencial)
            {
                if (valida.ValidaString(localizacao))
                    return $"O campo do local presencial não pode estar vazio!";
                else
                    return "";
            }

            return "";
        }

        public override void AtualizarInformacoes(Compromisso registroAtualizado)
        {
            this.assunto = registroAtualizado.assunto;
            this.data = registroAtualizado.data;
            this.horarioInicio = registroAtualizado.horarioInicio;
            this.horarioTermino = registroAtualizado.horarioTermino;
            this.localizacao = registroAtualizado.localizacao;
            this.contato = registroAtualizado.contato;
        }
    }
}
