﻿namespace E_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public virtual string? ToolTipFiltrar { get; }

        public virtual string? ToolTipAdicionarItens { get; }

        public virtual string? ToolTipConcluirItens { get; }

        public virtual bool InserirHabilitado { get { return false; } }
        public virtual bool EditarHabilitado { get { return false; } }
        public virtual bool ExcluirHabilitado { get { return false; } }

        public virtual bool FiltrarHabilitado { get { return false; } }
        public virtual bool AdicionarItensHabilitado { get { return false; } }
        public virtual bool ConcluirItensHabilitado { get { return false; } }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();

        public virtual void Filtrar(){}

        public virtual void AdicionarItens(){}

        public virtual void ConcluirItens(){}
    }
}
