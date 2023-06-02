using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoArquivo : RepositorioBaseArquivo<Contato>, IRepositorioContato
    {
        public RepositorioContatoArquivo(ContextoDeDados contexto) : base(contexto)
        {
            
        }

        protected override List<Contato> ObterRegistros()
        {
            return contextoDeDados.contatos;
        }
    }
}
