using e_Agenda.WinApp.ModuloContato;
using E_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        RepositorioContato repositorioContato;
        ListagemContatoControl listagemContato;

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo contato"; } }

        public override string ToolTipEditar { get { return "Editar contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir contato existente"; } }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }
    }
}
