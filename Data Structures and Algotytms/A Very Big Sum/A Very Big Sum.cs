using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A_Very_Big_Sum
{
    class Program
    {
        /*
     * Complete the aVeryBigSum function below.
     */
        static long aVeryBigSum(int n, long[] ar)
        {
            //long sum = 0;

            long sum = ar.Sum();

            //for (int i = 0; i < n; i++)
            //{
            //    sum += ar[i];
            //}

            return sum;
        }

        static void Main(string[] args)
        {
           // TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

            long result = aVeryBigSum(n, ar);

            Console.WriteLine(result);
            //tw.WriteLine(result);

            //tw.Flush();
            //tw.Close();
        }
    }
}