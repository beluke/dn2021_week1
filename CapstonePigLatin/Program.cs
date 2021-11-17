using System;
using System.Linq;

namespace CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Pig Latin Translator!");

            do
            {
                Console.Write("\nEnter a line to be translated: ");
                string input = Console.ReadLine().ToLower();

                Console.WriteLine("\nTranslation: " + string.Join(" ", input.Split(' ').Select(x => !"aeiou".Contains(x[0]) ? x[1..] + x[0] + "ay" : x + "way")));

                Console.Write("\nTranslate another line? ([y]es/[n]o) (default = no): ");
                input = Console.ReadLine().ToLower();

                if (input != "y" && input != "yes") break;

            } while (true);
        }
    }
}
