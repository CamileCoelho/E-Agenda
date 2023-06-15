using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.Dominio.Compartilhado
{
    [Serializable]
    public abstract class EntidadeBase<T>
    {
        public int id { get; set; }

        public abstract void AtualizarInformacoes(T registroAtualizado);

        public abstract string Validar();
    }
}
