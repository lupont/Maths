using Maths.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new Fraction(2, 4);
            var f2 = new Fraction(1, 2);
            var f3 = new Fraction(5, 3);
            Console.WriteLine(f1 == f2);
            Console.WriteLine(f1 == f3);
            Console.WriteLine(f2 == f3);
            Console.WriteLine(f1 != f2);
            Console.WriteLine(f1 != f3);
            Console.WriteLine(f2 != f3);
            Console.ReadKey();
        }
    }
}
