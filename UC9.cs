using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAy19RegexProb
{
    class UC9
    {
        //abc@yahoo.com
        public static string Email1 = "^[a-z]{3}[@][a-z]{5}[.][com]{3}$";

        //abc-100@yahoo.com
        public static string Email2 = "^[a-z]{3}[-][100]{3}[@][a-z]{5}[.][com]{3}$";

        //abc.100@yahoo.com
        public static string Email3 = "^[a-z]{3}[.][100]{3}[@][a-z]{5}[.][com]{3}$";

        //abc111@abc.com
        public static string Email4 = "^[a-z1-9]{6}[@][a-z]{3}[.][com]{3}$";

        public bool Validate1(string email)
        {
            return Regex.IsMatch(email, Email1);
        }
        public bool Validate2(string email)
        {
            return Regex.IsMatch(email, Email2);
        }
        public bool Validate3(string email)
        {
            return Regex.IsMatch(email, Email3);
        }
        public bool Validate4(string email)
        {
            return Regex.IsMatch(email, Email4);
        }
    }
}
