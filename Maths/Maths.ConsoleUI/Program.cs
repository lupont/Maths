using System;
using Maths.Core;
using System.Linq;
using System.Collections.Generic;

namespace Maths.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Skriv in en täljare: ");
                int numerator = int.Parse(Console.ReadLine());
                Console.Write("Skriv in en nämnare: ");
                int denominator = int.Parse(Console.ReadLine());
                var fraction = new Fraction(numerator, denominator);
                Console.WriteLine(fraction);
                Main(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error ocurred: {ex.Message}");
                Main(null);
            }
            Console.ReadKey();
        }
    }
}
