﻿using E_Agenda.Dominio.ModuloCompromissos;
using E_Agenda.Dominio.ModuloContato;

namespace E_Agenda.WinApp.ModuloCompromissos
{
    public partial class TelaCompromissoForm : Form
    {
        Compromisso compromisso;
        public TelaCompromissoForm()
        {

        }

        public TelaCompromissoForm(List<Contato> contatos)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarContatos(contatos);
        }

        private void CarregarContatos(List<Contato> contatos)
        {
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

            TipoLocalizacaoCompromissoEnum tipo = rbtOnline.Checked ? TipoLocalizacaoCompromissoEnum.Online :
                rbtPresencial.Checked ? TipoLocalizacaoCompromissoEnum.Presencial : TipoLocalizacaoCompromissoEnum.Nenhum;

            Contato contato = (Contato)cmbContatos.SelectedItem;

            string localizacao = "";

            if (rbtOnline.Checked)
                localizacao = txtLocalOnline.Text;
            if (rbtPresencial.Checked)
                localizacao = txtLocalPresencial.Text;

            return new Compromisso(assunto, data, horarioInicio, horarioFinal, contato, localizacao, tipo);
        }

        public void ConfigurarTela(Compromisso compromissoSelecionado)
        {
            txtId.Text = compromissoSelecionado.id.ToString();
            txtAssunto.Text = compromissoSelecionado.assunto;
            txtData.Value = compromissoSelecionado.data;
            txtInicio.Value = compromissoSelecionado.horarioInicio;
            txtTermino.Value = compromissoSelecionado.horarioTermino;

            if (compromissoSelecionado.contato != null)
            {
                chkSelecionarContato.Checked = true;
                cmbContatos.SelectedItem = compromissoSelecionado.contato;
            }

            if (compromissoSelecionado.tipoLocal == TipoLocalizacaoCompromissoEnum.Presencial)
            {
                rbtPresencial.Checked = true;
                txtLocalPresencial.Text = compromissoSelecionado.localizacao;
            }
            if (compromissoSelecionado.tipoLocal == TipoLocalizacaoCompromissoEnum.Online)
            {
                rbtOnline.Checked = true;
                txtLocalOnline.Text = compromissoSelecionado.localizacao;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            compromisso = ObterCompromisso();

            string status = compromisso.Validar();

            if (chkSelecionarContato.Checked == true && compromisso.contato == null)
                status = $"Você deve selecionar um contato ou desmarcar essa opção!";

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status.Length > 0)
                DialogResult = DialogResult.None;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}
