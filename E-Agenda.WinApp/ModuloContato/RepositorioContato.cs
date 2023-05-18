using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public void Editar(Contato contato)
        {
            Contato contatoSelecionado = (Contato)SelecionarPorId(contato.id);

            contatoSelecionado.informacoesPessoais.nome = contato.informacoesPessoais.nome;
            contatoSelecionado.informacoesPessoais.telefone = contato.informacoesPessoais.telefone;
            contatoSelecionado.informacoesPessoais.email = contato.informacoesPessoais.email;
            contatoSelecionado.cargo = contato.cargo;
            contatoSelecionado.empresa = contato.empresa;
        }
    }
}
