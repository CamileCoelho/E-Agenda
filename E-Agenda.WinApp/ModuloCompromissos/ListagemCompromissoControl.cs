using E_Agenda.WinApp.Compartilhado;
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
    public partial class ListagemCompromissoControl : UserControl
    {
        public ListagemCompromissoControl()
        {

            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Assunto", HeaderText = "Assunto"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Horário de Início", HeaderText = "Horário de Início"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Horário de Término", HeaderText = "Horário de Término"},
                
                new DataGridViewTextBoxColumn {DataPropertyName = "Online/Presencial", HeaderText = "Online/Presencial"},
                
                new DataGridViewTextBoxColumn {DataPropertyName = "Localização", HeaderText = "Localização"}
            };

            return colunas;
        }

        public int ObterNumeroCompromissoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();

            foreach (var compromisso in compromissos)
            {
                grid.Rows.Add(compromisso.id, compromisso.assunto, compromisso.data,
                    compromisso.horarioInicio, compromisso.horarioTermino, 
                    compromisso.tipoLocal, compromisso.localizacao);
            }
        }
    }
}
