using System;
using System.Text.RegularExpressions;

namespace RegexAteMyNeighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                // print menu
                Console.WriteLine("Welcome!\n\t" +
                    "1) Validate a full name\n\t" +
                    "2) Validate an email\n\t" +
                    "3) Validate a phone number\n\t" +
                    "4) Validate a date\n\t" +
                    "5) Validate a line of html\n\t" +
                    "0) Quit the program");

                // variable to store option
                int opt;
                // enter validation loop
                do
                {
                    // prompt user
                    Console.Write("\nPlease choose an option from the menu above (1-5 or 0 to quit): ");
                    try
                    {
                        // get option
                        opt = int.Parse(Console.ReadLine());
                        if (opt > 5 || opt < 0) throw new Exception("Invalid option...");
                    }
                    // catch exceptions (i.e. invalid input)
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        opt = -1;
                    }

                // continue loop while invalid option
                } while (opt < 0 || opt > 5);

                // result boolean
                bool result;
                // enter option switch
                switch (opt)
                {
                    // full name case
                    case 1:
                        Console.Write("\nEnter full name (format: first last): ");
                        result = ValidateName(Console.ReadLine());
                        Console.WriteLine("Name is " + ((result) ? "valid!" : "not valid, sorry."));
                        break;
                    // email address case
                    case 2:
                        Console.Write("\nEnter email address (format: user@provider.com): ");
                        result = ValidateEmail(Console.ReadLine());
                        Console.WriteLine("Email is " + ((result) ? "valid!" : "not valid, sorry."));
                        break;
                    // phone number case
                    case 3:
                        Console.Write("\nEnter phone number (format: ###-###-####): ");
                        result = ValidatePhone(Console.ReadLine());
                        Console.WriteLine("Phone number is " + ((result) ? "valid!" : "not valid, sorry."));
                        break;
                    // date case
                    case 4:
                        Console.Write("\nEnter date (format: dd/mm/yyyy): ");
                        result = ValidateDate(Console.ReadLine());
                        Console.WriteLine("Date is " + ((result) ? "valid!" : "not valid, sorry."));
                        break;
                    // html case
                    case 5:
                        Console.Write("\nEnter HMTL (format: <tag>anyting</tag>): ");
                        result = ValidateHTML(Console.ReadLine());
                        Console.WriteLine("HTML is " + ((result) ? "valid!" : "not valid, sorry."));
                        break;
                    // if opt is 0 or otherwise, just exit
                    default:
                        break;
                }

                // exit main loop if opt is 0
                if (opt == 0) break;

                // if opt is not 0 prompt user to hit enter key to restart
                Console.Write("\nPress [ENTER] to continue...");
                Console.ReadLine();
            } while (true);

        }

        static bool ValidateName(string name)
        {
            return Regex.IsMatch(name, "^[A-z]*\\b\\s[A-z]*$");
        }

        static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, "^[A-z0-9]{3,30}\\@[A-z0-9]{3,10}\\.[A-z]{2,3}$");
        }

        static bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, "^[0-9]{3}\\-[0-9]{3}\\-[0-9]{4}$");
        }

        static bool ValidateDate(string date)
        {
            return Regex.IsMatch(date, "^[0-9]{2}\\/[0-9]{2}\\/[0-9]{4}$");
        }

        static bool ValidateHTML(string html)
        {
            return Regex.IsMatch(html, "^\\<([A-z0-9]*)\\>.*\\n*\\<\\/(\\1)\\>$");
        }
    }
}
