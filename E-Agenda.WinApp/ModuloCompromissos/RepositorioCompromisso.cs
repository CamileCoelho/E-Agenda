using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public void Editar(Compromisso compromisso)
        {
            Compromisso compromissoSelecionado = (Compromisso)SelecionarPorId(compromisso.id);

            compromissoSelecionado.assunto = compromisso.assunto;
            compromissoSelecionado.data = compromisso.data;
            compromissoSelecionado.horarioInicio = compromisso.horarioInicio;
            compromissoSelecionado.horarioTermino = compromisso.horarioTermino;
            compromissoSelecionado.localizacao = compromisso.localizacao;
            compromissoSelecionado.contato = compromisso.contato;
        }
    }
}
