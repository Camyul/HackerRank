using System;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static int birthdayCakeCandles(int n, int[] ar)
        {
            int countResult = 1;
            int maxLenght = ar[0];

            for (int i = 1; i < ar.Length; i++)
            {
                if (maxLenght == ar[i])
                {
                    countResult++;
                }
                else if (maxLenght < ar[i])
                {
                    maxLenght = ar[i];
                    countResult = 1;
                }
            }

            return countResult;

        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = birthdayCakeCandles(n, ar);

            Console.WriteLine(result);
        }
    }
}
