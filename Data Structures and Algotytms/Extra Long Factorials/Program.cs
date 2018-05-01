using System;
using System.Numerics;

namespace Extra_Long_Factorials
{
    class Program
    {
        public static BigInteger factorial;

        static void Main(string[] args)
        {
            factorial = 1;
            int n = int.Parse(Console.ReadLine());

            extraLongFactorials(n);
        }

        private static void extraLongFactorials(int n)
        {
            BigInteger result = calcFactorial(n);

            Console.WriteLine(result);
        }

        private static BigInteger calcFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            factorial = calcFactorial(n - 1) * n;

            return factorial;
        }
    }
}
