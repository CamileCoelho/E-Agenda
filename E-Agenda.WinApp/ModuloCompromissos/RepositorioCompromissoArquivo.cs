using E_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public class RepositorioCompromissoArquivo : RepositorioBaseArquivoJson<Compromisso>, IRepositorioCompromisso
    {
        public List<Compromisso> SelecionarCompromissosPassados(DateOnly hoje)
        {
            return listaGeral.Where(x => x.data.Day < hoje.Day).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateOnly dataInicio, DateOnly dataFinal)
        {
            return listaGeral
                .Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList();
        }
    }
}
