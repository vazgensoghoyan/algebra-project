using static Algebra.Functions;
using static System.Math;

namespace Algebra
{
    /// <summary>
    /// This class represents rational numbers in fraction ??
    /// </summary>
    public class Number
    {
        /// <summary>
        /// Numerator of the fraction
        /// </summary>
        public int N { get; }
        /// <summary>
        /// Denominator of the fraction
        /// </summary>
        public uint D { get; }

        public Number(int a = 0, uint b = 1)
        {
            var gcd = Gcd((uint)Abs(a), b);

            N = (int)(a / gcd);
            D = (uint)(b / gcd);
        }

        public Number(double x)
        {
            var b = (uint)Pow(10, GetCountOfDecimalsAfter(x));
            var a = (int)(x * b);

            var gcd = Gcd((uint)Abs(a), b);

            N = (int)(a / gcd);
            D = (uint)(b / gcd);
        }

        public static Number operator *(Number a, Number b) => new( (int)(a.N * b.N), (uint)(a.D * b.D) );
        public static Number operator /(Number a, Number b) => new( (int)(a.N * b.D), (uint)(a.D * b.N) );
        public static Number operator +(Number a, Number b) => new( (int)(a.N * b.D + a.D * b.N), (uint)(a.D * b.D) );
        public static Number operator -(Number a) => new(-a.N, a.D);
        public static Number operator -(Number a, Number b) => a + (-b);


        public double ToDouble() => (double)N / D;
        public override string ToString()
        {
            if (ToDouble() % 1 == 0) return string.Format("{0}", ToDouble());

            return string.Format("{0}/{1}", N, D);
        }
    }
}
