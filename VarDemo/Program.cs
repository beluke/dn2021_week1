using System;

namespace VarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello \"World!");
            Console.WriteLine("Hello world line 2");

            string message = "hello world";
            Console.WriteLine(message);

            int AppleCount = 25;
            Console.WriteLine(AppleCount);
            Console.WriteLine(AppleCount + 1);
            Console.WriteLine(AppleCount);

            AppleCount = AppleCount + 10;
            Console.WriteLine(AppleCount);
            
            AppleCount = AppleCount * 10;
            Console.WriteLine(AppleCount);

            double x = 3.14;
            Console.WriteLine(x);

            // avoid using float
            float y = 6.28f;
            Console.WriteLine(y);

            double z = 20.0 / 3.0;
            Console.WriteLine(z);

            // use decimal type for financial programs
            decimal balance = 100.2512345m;
            Console.WriteLine(balance);

            bool atLunch = false;
            Console.WriteLine(atLunch);
            atLunch = true;
            Console.WriteLine(atLunch);

            // null cant be assigned to primitive types
            string test = null;
            Console.WriteLine(test);
        }
    }
}
