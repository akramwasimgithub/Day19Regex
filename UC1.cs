using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAy19RegexProb
{
    class UC1
    {
        public static string RegexForFirstName  = "^[A-Z][a-z]{3,}$"; //Wasim
        
        public bool ValidateFirstName(string firstname)
    {
        return Regex.IsMatch(firstname, RegexForFirstName);
        
    }
    }
}
