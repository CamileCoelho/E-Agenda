using E_Agenda.Dominio.ModuloContato;

namespace E_Agenda.Infra.Dados.Arquivo.ModuloContato
{
    public class RepositorioContatoArquivo : RepositorioBaseArquivo<Contato>, IRepositorioContato
    {
        public RepositorioContatoArquivo(ContextoDeDados contexto) : base(contexto)
        {
            
        }

        protected override List<Contato> ObterRegistros()
        {
            return contextoDeDados.contatos;
        }
    }
}
