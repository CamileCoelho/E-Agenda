using System.Text.Json;

namespace E_Agenda.WinApp.Compartilhado
{
    public class RepositorioBaseArquivoJson<T> where T : EntidadeBase<T>
    {
        protected List<T> listaGeral = new();

        protected int idContador = 0;

        private const string NOME_ARQUIVO = "Compartilhado/";

        public RepositorioBaseArquivoJson()
        {
            if (File.Exists(NOME_ARQUIVO + typeof(T).Name + ".json"))
                CarregarDoArquivo();
        }

        public void Inserir(T novoRegistro)
        {
            idContador++;
            novoRegistro.id = idContador;
            listaGeral.Add(novoRegistro);

            GravarEmArquivo();
        }

        public virtual void Editar(T registroSelecionado, T registroAtualizado)
        {
            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public void Editar(int id, T registro)
        {
            T contatoSelecionado = SelecionarPorId(id);

            contatoSelecionado.AtualizarInformacoes(registro);

            GravarEmArquivo();
        }

        public void Excluir(T registro)
        {
            listaGeral.Remove(registro);

            GravarEmArquivo();
        }

        public T SelecionarPorId(int id)
        {
            return listaGeral.FirstOrDefault(x => x.id == id);
        }

        public List<T> SelecionarTodos()
        {
            return listaGeral.OrderByDescending(x => x.id).ToList();
        }

        private void CarregarDoArquivo()
        {
            JsonSerializerOptions opcoes = new();
            opcoes.IncludeFields = true;

            string registrosJson = File.ReadAllText(NOME_ARQUIVO + typeof(T).Name + ".json");

            if (registrosJson.Length > 0)
                listaGeral = JsonSerializer.Deserialize<List<T>>(registrosJson, opcoes);
        }

        private void GravarEmArquivo()
        {
            JsonSerializerOptions opcoes = new();
            opcoes.WriteIndented = true;

            File.WriteAllText(NOME_ARQUIVO + typeof(T).Name + ".json", JsonSerializer.Serialize(listaGeral, opcoes));
        }
    }
}
