using E_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public void Editar(Contato contato)
        {
            Contato contatoSelecionado = SelecionarPorId(contato.id);

            contatoSelecionado.nome = contato.nome;
            contatoSelecionado.telefone = contato.telefone;
            contatoSelecionado.email = contato.email;
            contatoSelecionado.cargo = contato.cargo;
            contatoSelecionado.empresa = contato.empresa;
        }
    }
}
