using E_Agenda.WinApp.Compartilhado;

namespace E_Agenda.WinApp.ModuloContato
{
    public class ValidadorContato : Validador
    {
        public void ValidarInfoPessoal(InformacoesPessoais informacoesPessoais)
        {
            Validador valida = new();

            if (valida.ValidarString(informacoesPessoais.nome))
                MessageBox.Show($"Você deve escrever um nome!",
                    "Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            if (informacoesPessoais.telefone == null || valida.ValidaTelefone(informacoesPessoais.telefone))
                MessageBox.Show($"O telefone deve ser no formato (XX)XXXXX-XXXX",
                    "Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            if (informacoesPessoais.email == null || valida.ValidaFormatoEmail(informacoesPessoais.email))
                MessageBox.Show($"O e-mail deve ser no formato xxxxxx@xxxxx.xxx",
                    "Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }
    }
}
