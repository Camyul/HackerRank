using System;

namespace Plus_Minus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            int positives = 0;
            int negatives = 0;
            int zeroes = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positives++;
                }
                else if(arr[i] < 0)
                {
                    negatives++;
                }
                else
                {
                    zeroes++;
                }
            }

            Console.WriteLine(string.Format("{0:f6}", positives/(double)arr.Length));
            Console.WriteLine(string.Format("{0:f6}", negatives/(double)arr.Length));
            Console.WriteLine(string.Format("{0:f6}", zeroes/(double)arr.Length));

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
    }
}
