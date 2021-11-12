using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAy19RegexProb
{
    class UC3
    {
        public static string Email = "^[a-z]{3}[.]([a-z]{3})?[@][a-z]{2}[.][a-z]{2}([.][a-b])?$";  //abc.xyz@bl.co.in (abc bl co cumpolsary xyz,.in optional) [0-9]{2}[]

        public bool Validate(string email)
        {
            return Regex.IsMatch(email, Email);
        }


    }
}
