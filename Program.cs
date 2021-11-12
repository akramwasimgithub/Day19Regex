using System;

namespace DAy19RegexProb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UC1");
            Console.WriteLine("---");
            UC1 a = new UC1();
            Console.WriteLine(a.ValidateFirstName("Wasim"));
            Console.WriteLine("             ");

            Console.WriteLine("UC2");
            Console.WriteLine("---");
            UC2 b = new UC2();
            Console.WriteLine(a.ValidateFirstName("Akram"));
            Console.WriteLine("             ");

            Console.WriteLine("UC3");
            Console.WriteLine("---");
            UC3 c = new UC3();
            Console.WriteLine(c.Validate("imwasim322@gmial.com"));
            Console.WriteLine("             ");

            Console.WriteLine("UC4");
            Console.WriteLine("---");
            UC4 d = new UC4();
            Console.WriteLine(d.ValidatePhoneNum("+91 8370841564"));
            Console.WriteLine("             ");

            Console.WriteLine("Password");
            Console.WriteLine("---");
            UC5_6_7_8_Password e = new UC5_6_7_8_Password();
            Console.WriteLine(e.ValidatePwsd("MMMMhMMM5*K"));
            Console.WriteLine("             ");

            Console.WriteLine("Email1");
            Console.WriteLine("---");
            UC9 f = new UC9();
            Console.WriteLine(f.Validate1("abc@yahoo.com"));
            Console.WriteLine(f.Validate2("abc-100@yahoo.com"));
            Console.WriteLine(f.Validate3("abc.100@yahoo.com"));
            Console.WriteLine(f.Validate4("abc111@abc.com"));
            Console.WriteLine("             ");






        }
    }
}
