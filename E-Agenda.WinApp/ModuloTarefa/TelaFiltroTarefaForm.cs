
using E_Agenda.Dominio.ModuloTarefa;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaFiltroTarefaForm : Form
    {
        public TelaFiltroTarefaForm()
        {
            InitializeComponent();
        }

        public StatusTarefaEnum ObterFiltroTarefa()
        {
            if (rdbConcluidas.Checked == true)
                return StatusTarefaEnum.Concluidas;
            else if (rdbPendentes.Checked == true)
                return StatusTarefaEnum.Pendentes;
            else
                return StatusTarefaEnum.Todos;
        }
    }
}
