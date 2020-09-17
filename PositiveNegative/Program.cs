using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program checks if the number is positive or negative*/
            Console.WriteLine("Enter your number: ");

            int userInput = Int32.Parse(Console.ReadLine());
            
            if (userInput >= 0)
            {
                Console.WriteLine("This number is positive");
            } else
            {
                Console.WriteLine("This number is negative");
            }

        }
    }
}
