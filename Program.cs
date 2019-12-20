using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(1, 5);
            Fraction b = new Fraction(-1, 6);
            Console.WriteLine($"a-b =  {(a - b).Numerator} / {(a - b).Denominator}");
            Console.WriteLine($"a+b =  {(a + b).Numerator} / {(a + b).Denominator}");
            Console.WriteLine($"a*b =  {(a * b).Numerator} / {(a * b).Denominator}");
            Console.WriteLine($"(a < b)? =  { a<b }");
            Console.ReadKey();
        }
    }
}
