using System;
using System.Linq;
using System.Numerics;

namespace Recursive_Digit_Sum
{
    class Program
    {
        //static int digitSum(string n, int k)
        //{

        //    string number = string.Concat(Enumerable.Repeat(n, k));

        //    int result = Calc(int.Parse(number));

        //    return result;
        //}

        //public static int Calc(int num)
        //{
        //    if (num < 10)
        //    {
        //        return num;
        //    }

        //    int sum = 0;

        //    do
        //    {
        //        sum += num % 10;
        //        num = num / 10;
        //    }
        //    while (num > 0);

        //    int result = Calc(sum);

        //    return result;
        //}

        //static void Main(String[] args)
        //{
        //    string[] tokens_n = Console.ReadLine().Split(' ');
        //    string n = tokens_n[0];
        //    int k = Convert.ToInt32(tokens_n[1]);
        //    int result = digitSum(n, k);

        //    Console.WriteLine(result);
        //}

        static BigInteger digitSum(string n, int k)
        {

            string number = string.Concat(Enumerable.Repeat(n, k));

            //BigInteger sum = 0;

            //for (int i = 0; i < n.Length; i++)
            //{
            //    sum += (BigInteger)char.GetNumericValue(n[i]);
            //}

            //sum *= 3;

            //BigInteger result = Calc(sum.ToString());
            BigInteger result = Calc(number.ToString());

            return result;
        }

        public static BigInteger Calc(string number)
        {
            BigInteger num = BigInteger.Parse(number);

            if (num < 10)
            {
                return num;
            }

            BigInteger sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += (long)char.GetNumericValue(number[i]);
            }

            BigInteger result = Calc(sum.ToString());

            return result;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            string n = tokens_n[0];
            int k = Convert.ToInt32(tokens_n[1]);
            BigInteger result = digitSum(n, k);

            Console.WriteLine(result);
        }
    }
}
