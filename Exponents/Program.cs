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
                        if (num <= 0 || num > 1290)
                            throw new Exception("Number is not within bounds.");
                    }
                    catch (Exception e)
                    {
                        // repeat loop if exception caught
                        Console.WriteLine(e.Message);
                        continue;
                    }

                    // break if no exception caught, i.e. input is accepted
                    break;
                } while (true);

                
                // amount of padding to use for centering table header
                // used for centering cubed header
                int padding = new Func<int>(() => {
                    // use largest number length as measure, 5 is minimum
                    int x = $"{num * num * num}".Length > 5 ? $"{num * num * num}".Length : 5;
                    return (x / 2) + ((x / 2) % 2);
                })();

                // generate border using width w minus
                string hr(int w) => new string('─', w);
                // generate padding
                string pad() => new string(' ', padding / 2);

                // format and output table headers with borders
                Console.WriteLine($"┌{{0,-8}}┬{{1,-9}}┬{{2,-{5+padding}}}┐", hr(8), hr(9), hr(5+padding));
                Console.WriteLine($"│{{0,-8}}│{{1,-9}}│{{2,-{5+padding}}}│", " Number ", " Squared ", $"{pad()}Cubed{pad()}");
                Console.WriteLine($"├{{0,-8}}┼{{1,-9}}┼{{2,-{5+padding}}}┤", hr(8), hr(9), hr(5+padding));

                // calculate values, format and output table body width left and right borders
                for (int i = 1; i <= num; ++i)
                {
                    Console.WriteLine($"│{{0,8}}│{{1,9}}│{{2,{5 + padding}}}│", i, i * i, i * i * i);
                    if (i + 1 <= num) Console.WriteLine($"├{{0,-8}}┼{{1,-9}}┼{{2,-{5+padding}}}┤", hr(8), hr(9), hr(5+padding));
                }

                // format and output table bottom border
                Console.WriteLine($"└{{0,-8}}┴{{1,-9}}┴{{2,-{5+padding}}}┘", hr(8), hr(9), hr(5+padding));

                // prompt user to continue
                Console.Write("Continue? (y/n) (default = n) ");

            // continue loop only if input is 'y'
            } while (Console.ReadLine().ToLower() == "y");
            
        }
    }
}
