using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAy19RegexProb
{
    class UC5_6_7_8_Password
    {

        //minimum 8 charactor, atleast 1 upper case,
        //at least 1 numeric char,
        //exactly 1 special char must 
        // "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^$@!#%*?&]*[$#@!%*?&][^$@!#%*?&]*$).{8,}$
        public static string Password = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^$@!#%*?&]*[$#@!%*?&][^$@!#%*?&]*$).{8,}$"; 
       

        public bool ValidatePwsd(string pswd)
        {
            return Regex.IsMatch(pswd, Password);

        }
     
    }
}
