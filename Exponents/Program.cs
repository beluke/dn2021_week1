/*
 * Week 1, Lab 3: Exponents
 * Author: Luke Belinc
 */

using System;

namespace Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                // clear console upon loop
                Console.Clear();

                Console.WriteLine("Learn your squares and cubes!");

                // variables to store input data
                int num;
                string input;

                // enter validation loop
                do
                {
                    // get integer from user
                    Console.Write("\nPlease enter an integer larger than 0 and less than 1291: ");
                    input = Console.ReadLine();

                    try
                    {
                        // parse number from input
                        num = int.Parse(input);
                        // throw exception if number is not within bounds
                        if (num < 0 || num > 1290)
                            throw new Exception("Number is not within bounds.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }

                    // break if no exception caught, i.e. input is accepted
                    break;
                } while (true);

                // calculate table horizontal width minus 2 edges
                // if number uses n characters then width is (n + (n * 2)), assuming n is greater than 2
                // because longest header title is 7 characters so shortest total table width is 9
                int width = (input.Length > 2) ? input.Length + (input.Length * 2) : 7;
                // create horizontal rule of size width
                string hr = new string('─', width);

                // format and output table headers
                Console.WriteLine("┌{0," + width + "}┐ ┌{0," + width + "}┐ ┌{0," + width + "}┐", hr);
                Console.WriteLine("│{0," + width + "}│ │{1," + width + "}│ │{2," + width + "}│", "Number", "Squared", "Cubed");
                Console.WriteLine("├{0," + width + "}┤ ├{0," + width + "}┤ ├{0," + width + "}┤", hr);

                // calculate values, format and output table body
                for (int i = 1; i <= num; ++i)
                    Console.WriteLine("│{0," + width + "}│ │{1," + width + "}│ │{2," + width + "}│", i, i * i, i * i * i);

                // format and output table footer
                Console.WriteLine("└{0," + width + "}┘ └{0," + width + "}┘ └{0," + width + "}┘", hr);

                // prompt user to continue
                Console.Write("Continue? (y/n) (default = n) ");

            } while (Console.ReadLine().ToLower() == "y");
            
        }
    }
}
