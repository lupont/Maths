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
            int gcd = MathHelper.GCD(numerator, denominator);
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;
        } 
        #endregion

        #region Artithmetic operator overloading
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Fraction operator *(Fraction a, int lambda) => a * new Fraction(lambda, 1);
        public static Fraction operator *(int lambda, Fraction a) => a * new Fraction(lambda, 1);
        #endregion

        #region Logic operator overloading
        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return a.Numerator != b.Numerator || a.Denominator != b.Denominator;
        }
        #endregion

        #region Public overrides
        public override string ToString()
        {
            if (_numerator == 0)
                return "0";
            if (_denominator == 0)
                return _numerator.ToString();
            return $"{_numerator}/{_denominator}";
        } 
        #endregion
    }
}