using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAy19RegexProb
{
    class UC2
    {
        public static string LastName= "^[A-Z][a-z]{3,}$"; //Akram

        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, LastName);
        }
    }
}
