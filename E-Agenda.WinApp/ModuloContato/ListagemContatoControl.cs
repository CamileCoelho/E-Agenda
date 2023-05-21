using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloCompromissos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp.ModuloContato
{
    public partial class ListagemContatoControl : UserControl
    {
        public ListagemContatoControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "E-mail", HeaderText = "E-mail"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Empresa", HeaderText = "Empresa"}
            };

            return colunas;
        }

        public int ObtemNumeroCompromissoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            grid.Rows.Clear();

            foreach (var contato in contatos)
            {
                grid.Rows.Add(contato.id, contato.informacoesPessoais.nome,
                    contato.informacoesPessoais.telefone, contato.informacoesPessoais.email, contato.empresa,
                    contato.cargo);
            }
        }
    }
}
