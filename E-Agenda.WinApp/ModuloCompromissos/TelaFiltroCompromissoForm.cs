using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public partial class TelaFiltroCompromissoForm : Form
    {
        public TelaFiltroCompromissoForm()
        {
            InitializeComponent();
        }

        public StatusCompromissoEnum ObterStatus()
        {
            if (rdbFuturos.Checked)
            {
                return StatusCompromissoEnum.Futuros;
            }
            else if (rbdPassados.Checked)
            {
                return StatusCompromissoEnum.Passados;
            }
            else
            {
                return StatusCompromissoEnum.Todos;
            }
        }

        public DateOnly ObterDataInicio()
        {
            return DateOnly.FromDateTime(txtDataInicio.Value);
        }

        public DateOnly ObterDataFinal()
        {
            return DateOnly.FromDateTime(txtDataFinal.Value);
        }

        private void rdbFuturos_CheckedChanged(object sender, EventArgs e)
        {
            txtDataInicio.Enabled = !txtDataInicio.Enabled;
            txtDataFinal.Enabled = !txtDataFinal.Enabled;
        }
    }
}
