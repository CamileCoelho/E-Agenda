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

        public List<Contato> contatos;

        public TelaCompromissoForm()
        {
            InitializeComponent();

            configurarDateTime(dateTimeInicio);
            configurarDateTime(dateTimeTermino);
        }

        private void configurarDateTime(DateTimePicker data)
        {
            data.Format = DateTimePickerFormat.Custom;
            data.CustomFormat = "HH:mm";
            data.ShowUpDown = true;
        }

        public void ObterContatos(List<Contato> contatos)
        {
            this.contatos = contatos;
            foreach (Contato contato in contatos)
            {
                cmbContatos.Items.Add(contato.informacoesPessoais.nome);
            }
        }

        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
                txtLocal.Text = value.localizacao;
                txtLink.Text = value.localizacao;
                dateTimeInicio.Value = value.inicio;
                dateTimeTermino.Value = value.termino;
                dateTimeData.Value = value.data;
                if (value.contato != null)
                {
                    cmbContatos.SelectedItem = value.contato.informacoesPessoais.nome;
                }
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
