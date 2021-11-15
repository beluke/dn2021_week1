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
            Console.Write("\n" + name + ", the number {0} is", n);
            switch (n % 2)
            {
                case 0:
                    // even cases
                    Console.Write(" even");
                    if (n > 1 && n < 25) Console.Write(" and less than 25.\n");
                    else if (n <= 60) Console.Write(" and between 26 and 60 inclusive.\n");
                    else Console.Write(" and greater than 60.\n");
                    break;
                case 1:
                    // odd cases
                    Console.Write(" odd");
                    if (n < 60) Console.Write(" and less than 60.\n");
                    else Console.Write(" and greater than 60.\n");
                    break;
            }
        }
    }
}
