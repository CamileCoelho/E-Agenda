using E_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class ItemTarefa : EntidadeBase
    {
        public bool concluido { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }

        public void marcarConcluido()
        {
            concluido = true;
        }

        public void marcarPendente()
        {
            concluido = false;
        }
    }
}
