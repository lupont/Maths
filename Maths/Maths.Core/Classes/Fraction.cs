using System;

namespace Maths.Core
{
    public class Fraction
    {
        #region Private fields
        private int _numerator, _denominator;
        #endregion

        #region Public properties
        public int Numerator => _numerator;
        public int Denominator => _denominator;
        #endregion

        #region Public constructors
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("0 cannot be a denominator.");

            int gcd = MathHelper.GCD(numerator, denominator);
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;

            if (_denominator < 0)
            {
                _numerator *= -1;
                _denominator *= -1;
            }
        }
        #endregion

        #region Unitary operator overloading
        public static Fraction operator -(Fraction fraction)
        {
            return new Fraction(-fraction.Numerator, fraction.Denominator);
        }
        #endregion

        #region Artithmetic operator overloading
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator + a.Denominator * b.Numerator, a.Denominator * b.Denominator);
        }
        public static Fraction operator +(Fraction fraction, int lambda) => fraction + new Fraction(lambda, 1);
        public static Fraction operator +(int lambda, Fraction fraction) => fraction + new Fraction(lambda, 1);

        public static Fraction operator -(Fraction a, Fraction b) => a + -b;
        public static Fraction operator -(Fraction fraction, int lambda) => fraction - new Fraction(lambda, 1);
        public static Fraction operator -(int lambda, Fraction fraction) => fraction - new Fraction(lambda, 1);

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }
        public static Fraction operator *(Fraction fraction, int lambda) => fraction * new Fraction(lambda, 1);
        public static Fraction operator *(int lambda, Fraction fraction) => fraction * new Fraction(lambda, 1);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }
        public static Fraction operator /(Fraction fraction, int lambda) => fraction / new Fraction(lambda, 1);
        public static Fraction operator /(int lambda, Fraction fraction) => fraction / new Fraction(lambda, 1);
        #endregion

        #region Logic operator overloading
        public static bool operator ==(Fraction a, Fraction b) => a.Equals(b);

        public static bool operator !=(Fraction a, Fraction b) => !a.Equals(b);
        #endregion

        #region Public overrides
        public override bool Equals(object obj)
        {
            if (!(obj is Fraction fraction))
                return false;
            return _numerator == fraction.Numerator && _denominator == fraction.Denominator;
        }

        public override int GetHashCode()
        {
            int[] primes = { 31, 47 };
            int hash;
            hash = primes[0] * _numerator.GetHashCode() + primes[1];
            hash = hash * _denominator.GetHashCode() + primes[1];
            return hash;
        }

        public override string ToString()
        {
            if (_numerator == 0 || _denominator == 1)
                return _numerator.ToString();
            return $"{_numerator}/{_denominator}";
        } 
        #endregion
    }
}