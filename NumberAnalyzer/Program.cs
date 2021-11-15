/*
 * Week 1 Lab 2: Number Analyzer
 * Author: Luke Belinc
 */

using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt for name
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            // ask for a number
            Console.Write("\nHello, {0}, please enter an integer between 1 and 100 (inclusive): ", name);
            uint n = uint.Parse(Console.ReadLine());

            // input validation
            while (n < 1 || n > 100)
            {
                Console.WriteLine("Number outside of range...");
                Console.Write("Enter an integer between 1 and 100 (inclusive): ");
                n = uint.Parse(Console.ReadLine());
            }

            // output result
            Console.Write("\n" + name + ", the number is {0} and", n);
            switch (n % 2)
            {
                case 0:
                    Console.Write(" even");
                    if (n > 1 && n < 25) Console.Write(" and less than 25");
                    break;
                case 1:
                    Console.Write(" odd");
                    break;
            }
            Console.WriteLine();
        }
    }
}
