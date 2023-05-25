﻿
using System;
using System.Text.RegularExpressions;

namespace E_Agenda.WinApp.Compartilhado
{
    public class Validador
    {
        public Validador()
        {
            
        }

        public bool ValidaString(string str)
        {
            if (string.IsNullOrEmpty(str) && string.IsNullOrWhiteSpace(str))
                return true;
            else
                return false;
        }

        public bool ValidaEnum(Enum e)
        {
            if (string.IsNullOrEmpty(e.ToString()) && string.IsNullOrWhiteSpace(e.ToString()))
                return true;
            else
                return false;
        }

        public bool ValidaTelefone(string telefone)
        {
            // formato (XX)XXXXX-XXXX
            Regex Rgx = new(@"^\(\d{2}\)\ \d{5}-\d{4}$");

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

        public bool ValidaDateTime(DateTime date)
        {
            if (string.IsNullOrEmpty(date.ToString()) && string.IsNullOrWhiteSpace(date.ToString()))
                return true;
            if (date == DateTime.MinValue)
                return true; 
            else
                return false;
        }

        public bool ValidaDateOnly(DateOnly data)
        {
            if (string.IsNullOrEmpty(data.ToString()) && string.IsNullOrWhiteSpace(data.ToString()))
                return true;
            if (data == DateOnly.MinValue)
                return true;
            else
                return false;
        }

        public bool ValidaTimeOnly(TimeOnly hora)
        {
            if (string.IsNullOrEmpty(hora.ToString()) && string.IsNullOrWhiteSpace(hora.ToString()))
                return true;
            if (hora == TimeOnly.MinValue)
                return true;
            else
                return false;
        }
    }
}
