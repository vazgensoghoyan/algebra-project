using static System.Math;

namespace Algebra
{
    public class Functions
    {
        public static uint Gcd(uint a, uint b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a + b;
        }

        public static uint Lcm(uint a, uint b)
        {
            return (a * b) / Gcd(a, b);
        }

        public static int GetCountOfDecimalsBefore(double x)
        {
            return (int)Floor(Log10(x)) + 1;
        }

        public static int GetCountOfDecimalsAfter(double x)
        {
            var l = x.ToString().Length;
            var d = GetCountOfDecimalsBefore(x);

            return l - d - (l == d ? 0 : 1);
        }
    }
}