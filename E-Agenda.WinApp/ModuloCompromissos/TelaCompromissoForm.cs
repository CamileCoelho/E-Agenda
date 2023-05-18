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
    public partial class TelaCompromissoForm : Form
    {
        Compromisso compromisso;

        public TelaCompromissoForm()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            set
            {
                //txtId.Text = value.id.ToString();
                //txtNome.Text = value.nome;
                //txtTelefone.Text = value.telefone;
                //txtEmail.Text = value.email;
                //txtCargo.Text = value.cargo;
                //txtEmpresa.Text = value.empresa;
            }
            get
            {
                return compromisso;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //string nome = txtNome.Text;

            //string telefone = txtTelefone.Text;

            //string email = txtEmail.Text;

            //string cargo = txtCargo.Text;
            //string empresa = txtEmpresa.Text;

            //compromisso = new Compromisso(dfksdkdjsfkdjfjdfk,fdsjfkdjfk);

            //if (txtId.Text != "0")
            //    compromisso.id = Convert.ToInt32(txtId.Text);
        }
    }
}
