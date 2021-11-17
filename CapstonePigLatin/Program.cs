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
                string input = Console.ReadLine();

                if (input.Length <= 0)
                {
                    Console.WriteLine("\nPlease dont input empty strings...");
                    continue;
                }

                // convert string into pig latin
                // * separate string by spaces into array
                // * select each string in array
                // * regex match letters at beginning of word with non vowels
                // * generate new strings accordingly
                // * join string array returned from select using spaces
                // * finally, print output
                Console.WriteLine("\nTranslation: " + string.Join(" ", input.Split(' ').Select(word => {
                    // if word matches special character or has numbers, just return it
                    if (Regex.IsMatch(word, "([0-9@])")) return word;

                    // case flags
                    bool titleCase = false;
                    bool allUpper = false;

                    // update case flags
                    if (word.Equals(word.ToUpper())) allUpper = true;
                    else if (word[0].Equals(char.ToUpper(word[0]))) titleCase = true;

                    // get length of beginning consonant cluster (using as index for substring)
                    int idx = Regex.Match(word, "^([^aeiou]*)").Length;

                    // generate new string while minding location of period
                    // if period is in middle, ignore it, otherwise move it to end
                    if (word.IndexOf(".") == word.Length - 1)
                        word = idx > 0 ? word[idx..(word.Length - 1)] + word[0..idx] + "ay." : word[0..(word.Length - 1)] + "way.";
                    else
                        word = idx > 0 ? word[idx..] + word[0..idx] + "ay" : word[0..] + "way";


                    // fix case
                    if (titleCase)
                    {
                        word = word.ToLower();
                        word = char.ToUpper(word[0]) + word[1..];
                    }
                    else if (allUpper)
                    {
                        word = word.ToUpper();
                    }

                    // return word
                    return word;
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
