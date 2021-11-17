using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            // print title
            Console.WriteLine("\nWelcome to the Pig Latin Translator!");

            // enter main loop
            do
            {
                // prompt user for input
                Console.Write("\nEnter a line to be translated: ");
                string input = Console.ReadLine().ToLower();

                // convert string into pig latin
                // * separate string by spaces into array
                // * select each string in array
                // * regex match letters at beginning of word with non vowels
                // * generate new strings accordingly
                // * join string array returned from select using spaces
                // * finally, print output
                Console.WriteLine("\nTranslation: " + string.Join(" ", input.Split(' ').Select(word => { 
                    int idx = Regex.Match(word, "^([^aeiou]*)").Length;
                    return idx > 0 ? word[idx..] + word[0..idx] + "ay" : word + "way";
                })));

                // prompt to continue
                Console.Write("\nTranslate another line? ([y]es/[n]o) (default = no): ");
                input = Console.ReadLine().ToLower();

                // break if input is not "yes" or "y"
                if (input != "y" && input != "yes") break;
            // loop controlled by conditional above
            } while (true);
        }
    }
}
