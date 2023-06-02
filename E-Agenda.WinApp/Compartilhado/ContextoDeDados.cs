using E_Agenda.WinApp.ModuloCompromissos;
using E_Agenda.WinApp.ModuloContato;
using E_Agenda.WinApp.ModuloTarefa;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace E_Agenda.WinApp.Compartilhado
{
    public class ContextoDeDados
    {
        private const string NOME_ARQUIVO = "Compartilhado//E-Agenda.json";

        public List<Contato> contatos { get; set; }
        public List<Tarefa> tarefas { get; set; }
        public List<Compromisso> compromissos { get; set; }

        public ContextoDeDados()
        {
            contatos = new List<Contato>();
            compromissos = new List<Compromisso>();
            tarefas = new List<Tarefa>();
        }

        public ContextoDeDados(bool carregarDados) : this()
        {
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            File.WriteAllText(NOME_ARQUIVO, JsonSerializer.Serialize(this, config));
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO) && File.ReadAllText(NOME_ARQUIVO).Length > 0)
            {
                ContextoDeDados ctx = JsonSerializer.Deserialize<ContextoDeDados>(File.ReadAllText(NOME_ARQUIVO), config);

                contatos = ctx.contatos;
                compromissos = ctx.compromissos;
                tarefas = ctx.tarefas;
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new();
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
