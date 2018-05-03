using System;
using System.IO;

namespace Diagonal_Difference
{
    class Program
    {
        static int diagonalDifference(int[][] a, int n)
        {
            
            int leftDiagonal = 0;
            int rightDiagonal = 0;

            for (int i = 0, j = 0; i < n; i++, j++)
            {
                leftDiagonal += a[i][j];
                rightDiagonal += a[i][n - 1 - j];
            }

            int result = Math.Abs(leftDiagonal - rightDiagonal);

            return result;

        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] a = new int[n][];

            for (int aRowItr = 0; aRowItr < n; aRowItr++)
            {
                a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            }

            int result = diagonalDifference(a, n);

            Console.WriteLine(result);
        }
    }
}
