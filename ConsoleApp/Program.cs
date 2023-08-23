using Algebra;
using static Algebra.Functions;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Gcd(9, 12));
            Console.WriteLine(Lcm(9, 12));

            Console.WriteLine(GetCountOfDecimalsAfter(1567));
            Console.WriteLine(GetCountOfDecimalsAfter(193998.1888));
            Console.WriteLine(GetCountOfDecimalsBefore(547389));
            Console.WriteLine(GetCountOfDecimalsBefore(18838.9991765));

            var a1 = new Number(0.2817);
            var a2 = new Number(1020, 16);
            var a3 = new Number(199);
            var a4 = new Number();

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);

            Console.WriteLine(a1 + a2);
            Console.WriteLine(a1 + a3);
            Console.WriteLine(a2 + a3);
            Console.WriteLine(a1 + a2 + a3);
        }
    }
}