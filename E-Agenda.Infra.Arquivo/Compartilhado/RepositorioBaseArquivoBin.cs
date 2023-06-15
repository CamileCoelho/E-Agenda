using System.Runtime.Serialization.Formatters.Binary;

namespace E_Agenda.Infra.Dados.Arquivo.Compartilhado
{
    public  class RepositorioBaseArquivoBin<T> where T : EntidadeBase<T>
    {
        protected List<T> listaGeral = new();

        protected int idContador = 0;

        private const string NOME_ARQUIVO = "C:\\Users\\Sony\\Documents\\camile 2022\\" +
            "AcademiaDoProgramador\\2023\\e-agenda.winapp\\E-agenda\\E-Agenda.WinApp\\bin\\";

        public RepositorioBaseArquivoBin()
        {
            if (File.Exists(NOME_ARQUIVO + typeof(T).Name + ".bin"))
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
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] contatoEmBytes = File.ReadAllBytes(NOME_ARQUIVO + typeof(T).Name + ".bin");

            MemoryStream contatoStream = new MemoryStream(contatoEmBytes);

            listaGeral = (List<T>)serializador.Deserialize(contatoStream);
            AtualizarContador();
        }

        private void AtualizarContador()
        {
            idContador = listaGeral.Max(x => x.id);
        }

        private void GravarEmArquivo()
        {
            BinaryFormatter serializador = new();

            MemoryStream contatoStream = new();

            serializador.Serialize(contatoStream, listaGeral);

            byte[] contatoEmBytes = contatoStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO + typeof(T).Name + ".bin", contatoEmBytes);
        }
    }
}
