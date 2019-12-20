using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLibrary
{
    class Fraction
    {
        public long Numerator { get; private set; }
        public short Denominator { get; private set; }
        public Fraction(long num,short denom)
        {
            Numerator = num * denom/Math.Abs(denom);
            Denominator = denom != 0 ? Math.Abs(denom) : throw new Exception("Denominator is 0");
            Reduction(this);
        }
        public static Fraction Reduction(Fraction a)
        {
            for (long i = (a.Denominator >= Math.Abs(a.Numerator))? a.Denominator : Math.Abs(a.Numerator); i >= 2; i--)
            {
                if(a.Denominator % i == 0 && a.Numerator % i == 0)
                {
                    a.Numerator /= i;
                    a.Denominator = (short)(a.Denominator / i);
                    break;
                }
            }
            return a;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return Reduction(new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, (short)(a.Denominator * b.Denominator)));
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return Reduction(new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator, (short)(a.Denominator * b.Denominator)));
        }
        public static Fraction operator * (Fraction a,Fraction b)
        {
            return Reduction(new Fraction(a.Numerator * b.Numerator, (short)(a.Denominator * b.Denominator)));
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return (a.Numerator * b.Denominator < b.Numerator * a.Denominator) ? true : false;
        }
        public static  bool operator >(Fraction a,Fraction b)
        {
            return (a.Numerator * b.Denominator > b.Numerator * a.Denominator) ? true : false;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            return (a.Numerator * b.Denominator >= b.Numerator * a.Denominator) ? true : false;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            return (a.Numerator * b.Denominator <= b.Numerator * a.Denominator) ? true : false;
        }
    }
}
