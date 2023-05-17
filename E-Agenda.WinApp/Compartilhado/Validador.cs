
using System.Text.RegularExpressions;

namespace E_Agenda.WinApp.Compartilhado
{
    public class Validador
    {
        public Validador()
        {
            
        }

        public bool ValidarString(string str)
        {
            if (string.IsNullOrEmpty(str) && string.IsNullOrWhiteSpace(str))
                return true;
            else
                return false;
        }

        public bool ValidaTelefone(string telefone)
        {
            // formato (XX)XXXXX-XXXX
            Regex Rgx = new(@"^\(\d{2}\)\d{5}-\d{4}$");

            if (Rgx.IsMatch(telefone))
                return false;
            else
                return true;
        }

        public bool ValidaFormatoEmail(string email)
        {
            // formato permitido: qualquer coisa antes do "@" seguido por pelo menos uma letra depois
            Regex Rgx = new(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");

            if (Rgx.IsMatch(email))
                return false;
            else
                return true;
        }

        public bool ValidaEmail(string email)
        {
            // formato permitido: qualquer coisa antes do "@" seguido por pelo menos um caractere depois
            Regex Rgx = new(@"^[^\s@]+@[^\s@]+$");

            if (Rgx.IsMatch(email))
                return false;
            else
                return true;
        }
    }
}
