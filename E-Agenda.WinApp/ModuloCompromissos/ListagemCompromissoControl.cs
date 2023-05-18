using E_Agenda.WinApp.ModuloContato;
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
    public partial class listaCompromisso : UserControl
    {
        public listaCompromisso()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            listCompromisso.Items.Clear();

            foreach (Compromisso item in compromissos)
            {
                listCompromisso.Items.Add(item);
            }
        }

        public Compromisso ObterContatoSelecionado()
        {
            return (Compromisso)listCompromisso.SelectedItem;
        }
    }
}
