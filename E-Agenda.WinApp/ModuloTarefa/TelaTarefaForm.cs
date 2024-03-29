﻿using E_Agenda.Dominio.ModuloCompromissos;
using E_Agenda.Dominio.ModuloTarefa;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;

        public TelaTarefaForm(bool edicaoDaTarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarPrioridades();

            if (edicaoDaTarefa)
            {
                txtDataCriacao.Enabled = false;
            }
        }

        public Tarefa ObterTarefa()
        {
            string titulo = txtTitulo.Text;

            TipoPrioridadeTarefaEnum prioridade = TipoPrioridadeTarefaEnum.Nenhuma;

            if (cmbPrioridades.SelectedItem == null)
            {
                prioridade = TipoPrioridadeTarefaEnum.Nenhuma;
            }
            if (cmbPrioridades.SelectedItem != null)
            {
                prioridade = (TipoPrioridadeTarefaEnum)cmbPrioridades.SelectedItem;
            }

            DateTime dataCriacao = txtDataCriacao.Value;

            return new(titulo, prioridade, dataCriacao);
        }

        public void CarregarPrioridades()
        {
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Alta);
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Normal);
            cmbPrioridades.Items.Add(TipoPrioridadeTarefaEnum.Baixa);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tarefa = ObterTarefa();

            string status = tarefa.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
                DialogResult = DialogResult.None;
        }

        public void ConfigurarTela(Tarefa tarefaSelecionada)
        {
            txtId.Text = tarefaSelecionada.id.ToString();
            txtTitulo.Text = tarefaSelecionada.titulo;
            cmbPrioridades.Text = tarefaSelecionada.prioridade.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}
