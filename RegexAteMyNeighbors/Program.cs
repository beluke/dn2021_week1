using System;
using System.Text.RegularExpressions;

namespace RegexAteMyNeighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\n\t" +
                "1) Validate a full name\n\t" +
                "2) Validate an email\n\t" +
                "3) Validate a phone number\n\t" +
                "4) Validate a date\n\t" +
                "5)Validate a line of html\n\t" +
                "0) Quit the program");

            Console.Write("\nPlease choose an option from the menu above (1-5 or 0 to quit): ");
            string input = Console.ReadLine();
        }

        static bool ValidateName(string name)
        {
            return Regex.IsMatch(name, "/^[a-z]*\\b\\s[A-z]*$/gmi");
        }

        static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, "/^[a-z0-9]{5,30}\\@[a-z0-9]{5,10}\\.[A-z]{2,3}$/gi");
        }

        static bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, "/^[0-9]{3}\\-?[0-9]{3}\\-?[0-9]{4}$/gi");
        }

        static bool ValidateDate(string date)
        {
            return Regex.IsMatch(date, "/^[0-9]{2}\\/[0-9]{2}\\/[0-9]{4}/gi");
        }

        static bool ValidateHTML(string html)
        {
            return Regex.IsMatch(html, "/^\\<([a-z0-9]*)\\>.*\\n*\\<\\/(\\1)\\>$/gi");
        }
    }
}
