using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Factorial Calculator!");

            // enter main loop 
            do
            {
                // prompt user for input
                Console.Write("\nEnter a number greather than 0 and less than 10: ");
                int n = int.Parse(Console.ReadLine());

                // validation loop
                while (n > 9 || n < 1)
                {
                    Console.WriteLine("\nNumber out of range...");
                    Console.Write("Please enter a number greater than 0 and less than 10: ");
                    n = int.Parse(Console.ReadLine());
                }

                // lambda for calculating factorial
                static int fact(int x) => (x == 1) ? x : x * fact(x - 1);

                // caclulate and display result
                Console.WriteLine($"\nThe factorial of {n} is {fact(n)}");
                // could also use
                //Console.WriteLine($"\nThe factorial of {n} is {CalcFactorial(n)}");

                // prompt to conitnue
                Console.Write("\nContinue? (y/n) (default = n): ");

            // only continue if input is equal to "y"
            } while (Console.ReadLine().ToLower() == "y");

        }

        // not using but keeping for reference
        static int CalcFactorial(int x)
        {
            return x == 1 ? x : x * CalcFactorial(x - 1);
        }
    }
}
