/*
 * Week 1, Lab 1: Room Calculator
 * Author: Luke Belinc
 */
using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                // clear console to get rid of extra stuff
                Console.Clear();

                // welcome message
                Console.WriteLine("Welcome to the Grand Circus's Room Detail Generator!");

                // prompt user
                Console.Write("\nEnter room length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter room width: ");
                double width = double.Parse(Console.ReadLine());

                // calculate area and save for later use
                double area = length * width;
                // calculate area and perimeter
                Console.WriteLine("\nArea: {0}", area);
                Console.WriteLine("Perimeter: {0}", (length + width) * 2);
                // output room size classification
                Console.WriteLine("Room size: " + ((area <= 250) ? "small\n" : (area <= 650) ? "medium\n" : "large\n"));

                // ask user if they want to calculate volume and surface area
                Console.Write("Calculate volume and surface area? (y/n) (default = n) ");
                if (Console.ReadLine() == "y")
                {
                    // get height
                    Console.Write("\nEnter room height: ");
                    double height = double.Parse(Console.ReadLine());
                    // calculate volume and surface area
                    Console.WriteLine("\nVolume: {0}", area * height);
                    Console.WriteLine("Surface Area: {0}", (area + ((length + width) * height)) * 2);
                }

                // prompt user to see if they want to keep going
                Console.Write("\nDo you want to make another calculation? (y/n) (default = n) ");

            } while (Console.ReadLine() == "y");
        }
    }
}
