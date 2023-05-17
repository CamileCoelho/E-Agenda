using E_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        public override string ToolTipInserir { get { return "Inserir nova tarefa"; } }

        public override string ToolTipEditar { get { return "Editar tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluír tarefa existente"; } }

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
            return "Cadastro de Tarefas";
        }
    }
}
