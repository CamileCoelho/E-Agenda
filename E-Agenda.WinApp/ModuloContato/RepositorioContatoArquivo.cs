using E_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoArquivo : RepositorioBaseArquivoJson<Contato>, IRepositorioContato
    {

    }
}
