using System;
using System.Text;

namespace Staircase
{
    class Program
    {
        static void staircase(int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    sb.Append(" ");
                }
                for (int j = n - 1 - i; j < n; j++)
                {
                    sb.Append("#");
                }
                sb.Append("\n");
            }

            Console.WriteLine(sb.ToString());

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
