using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public interface IRepositorioCompromisso : IRepositorio<Compromisso>
    {
        List<Compromisso> SelecionarCompromissosPassados(DateOnly hoje);
        List<Compromisso> SelecionarCompromissosFuturos(DateOnly dataInicio, DateOnly dataFinal);
    }
}
