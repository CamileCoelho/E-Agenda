using System.Xml.Serialization;

namespace E_Agenda.Infra.Dados.Arquivo.Compartilhado
{
    public class RepositorioBaseArquivoXml<T> where T : EntidadeBase<T>
    {
        protected List<T> listaGeral = new();

        protected int idContador = 0;

        private const string NOME_ARQUIVO = "Compartilhado/";

        public RepositorioBaseArquivoXml()
        {
            if (File.Exists(NOME_ARQUIVO + typeof(T).Name + ".xml"))
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

        private void GravarEmArquivo()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<T>));

            MemoryStream registroStream = new MemoryStream();

            serializador.Serialize(registroStream, listaGeral);

            byte[] registroEmBytes = registroStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO + typeof(T).Name + ".xml", registroEmBytes);
        }

        private void CarregarDoArquivo()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<T>));

            byte[] registroEmBytes = File.ReadAllBytes(NOME_ARQUIVO + typeof(T).Name + ".xml");

            MemoryStream registroStream = new MemoryStream(registroEmBytes);

            if (registroStream.Length > 10)
            {
                listaGeral = (List<T>)serializador.Deserialize(registroStream);
                AtualizarContador();
            }
        }

        private void AtualizarContador()
        {
            idContador = listaGeral.Max(x => x.id);
        }
    }
}
