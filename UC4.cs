using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAy19RegexProb
{
    class UC4
    {
        public static string PhoneNumber = "^[+][9][1][ ][6-9]{1}[0-9]{9}$"; //+91 8468126432
         
        public bool ValidatePhoneNum(string phonNo)
        {
            return Regex.IsMatch(phonNo, PhoneNumber);
        }
    }
}
