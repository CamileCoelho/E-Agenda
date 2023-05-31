using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.Compartilhado
{
    public interface IRepositorio<T> where T : EntidadeBase<T>
    {
        void Inserir(T novoRegistro);

        void Editar(T registroSelecionado, T registroAtualizado);

        void Editar(int id, T registro);

        void Excluir(T registro);

        List<T> SelecionarTodos();

        T SelecionarPorId(int id);
    }
}
