using E_Agenda.WinApp.Compartilhado;
using E_Agenda.WinApp.ModuloContato;
using System;
using System.Xml.Linq;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public partial class TelaCompromissoForm : Form
    {
        Compromisso compromisso;

        public TelaCompromissoForm(List<Contato> contatos)
        {
            InitializeComponent();

            foreach (Contato contato in contatos)
            {
                cmbContatos.Items.Add(contato);
            }
        }

        public Compromisso ObterCompromisso()
        {
            string assunto = txtAssunto.Text;
            DateOnly data = DateOnly.FromDateTime(txtData.Value);
            TimeOnly horarioInicio = TimeOnly.FromDateTime(txtInicio.Value);
            TimeOnly horarioFinal = TimeOnly.FromDateTime(txtTermino.Value);

            TipoLocalizacaoCompromissoEnum tipo = rbtOnline.Checked ? TipoLocalizacaoCompromissoEnum.Online : TipoLocalizacaoCompromissoEnum.Presencial;

            Contato contato = (Contato)cmbContatos.SelectedItem;

            string localizacao;
            if (rbtOnline.Checked)
                localizacao = txtLocalOnline.Text;
            else
                localizacao = txtLocalPresencial.Text;


            return new Compromisso(assunto, data, horarioInicio, horarioFinal, contato, localizacao, tipo);
        }

        public void ConfigurarTela(Compromisso compromissoSelecionado)
        {
            txtId.Text = compromissoSelecionado.id.ToString();
            txtAssunto.Text = compromissoSelecionado.assunto;
            txtData.Value = compromissoSelecionado.data.ToDateTime(TimeOnly.Parse("00:00 AM"));
            txtInicio.Value = Convert.ToDateTime(compromissoSelecionado.horarioInicio);
            txtTermino.Value = Convert.ToDateTime(compromissoSelecionado.horarioTermino);
            //txtInicio.Value = DateTime.Now.Date.Add(compromissoSelecionado.horarioInicio);
            //txtTermino.Value = DateTime.Now.Date.Add(compromissoSelecionado.horarioTermino);

            if (compromissoSelecionado.contato == null)
            {
                chkSelecionarContato.Checked = true;
                cmbContatos.SelectedItem = compromissoSelecionado.contato;
            }

            if (compromissoSelecionado.tipoLocal == TipoLocalizacaoCompromissoEnum.Presencial)
            {
                rbtPresencial.Checked = true;
                txtLocalPresencial.Text = compromissoSelecionado.localPresencial;
            }
            else
            {
                rbtOnline.Checked = true;
                txtLocalOnline.Text = compromissoSelecionado.localOnline;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            compromisso = ObterCompromisso();

            string status = compromisso.Validar();

            if (status.Length > 0)
            {
                TelaPrincipalForm.Tela.atualizarRodape(status);

                DialogResult = DialogResult.None;
            }
        }

        private void rbtPresencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalPresencial.Enabled = true;
            txtLocalOnline.Enabled = false;
            txtLocalOnline.Text = "";

        }

        private void rbtOnline_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalOnline.Enabled = true;
            txtLocalPresencial.Enabled = false;
            txtLocalPresencial.Text = "";
        }

        private void chkSelecionarContato_CheckedChanged(object sender, EventArgs e)
        {
            cmbContatos.Enabled = !cmbContatos.Enabled;
            cmbContatos.SelectedIndex = -1;
        }
    }
}
