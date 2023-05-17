using E_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace E_Agenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase
    {
        public InformacoesPessoais informacoesPessoais {  get; set; }
        public string cargo { get; set; }
        public string empresa { get; set; }

        public Contato(InformacoesPessoais informacoesPessoais, string cargo, string empresa)
        {
            this.informacoesPessoais = informacoesPessoais;
            this.cargo = cargo;
            this.empresa = empresa;
        }
        public override string ToString()
        {
            return "Id: " + id + ", " + informacoesPessoais.nome + ", Empresa: " + empresa;
        }
    }
}
