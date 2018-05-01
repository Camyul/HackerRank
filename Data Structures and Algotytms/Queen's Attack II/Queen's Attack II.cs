using System;
using System.Linq;

namespace Queen_s_Attack_II
{
    class Program
    {
        static int queensAttack(int n, int r_q, int c_q, Cell[,] obstacles)
        {
            int result = 0;

            //Down
            for (int i = r_q + 1; i < n; i++)
            {
                if (obstacles[i, c_q].IsObstackle == true)
                {
                    break;
                }

                result++;
            }

            //Up
            for (int i = r_q - 1; i >= 0; i--)
            {
                if (obstacles[i, c_q].IsObstackle == true)
                {
                    break;
                }

                result++;
            }

            //Left
            for (int i = c_q - 1; i >= 0; i--)
            {
                if (obstacles[r_q, i].IsObstackle == true)
                {
                    break;
                }

                result++;
            }

            //Right
            for (int i = c_q + 1; i < n; i++)
            {
                if (obstacles[r_q, i].IsObstackle == true)
                {
                    break;
                }

                result++;
            }

            //Down Left
            int j = c_q;
            for (int i = r_q + 1; i < n; i++)
            {
                j--;
                if (j < 0)
                {
                    break;
                }

                if (obstacles[i, j].IsObstackle == true)
                {
                    break;
                }

                result++;
            }

            //Down Right
            j = c_q;
            for (int i = r_q + 1; i < n; i++)
            {
                j++;
                if (j >= n)
                {
                    break;
                }

                if (obstacles[i, j].IsObstackle == true)
                {
                    break;
                }

                result++;
            }

            //Up Left
            j = c_q;
            for (int i = r_q - 1; i >= 0; i--)
            {
                j--;
                if (j < 0)
                {
                    break;
                }

                if (obstacles[i, j].IsObstackle == true)
                {
                    break;
                }

                result++;
            }

            //Up Right
            j = c_q;
            for (int i = r_q - 1; i >= 0; i--)
            {
                j++;
                if (j >= n)
                {
                    break;
                }

                if (obstacles[i, j].IsObstackle == true)
                {
                    break;
                }

                result++;
            }

            return result;
        }

        public class Cell
        {
            public bool IsObstackle { get; set; }
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] tokens_r_q = Console.ReadLine().Split(' ');
            int r_q = Math.Abs(Convert.ToInt32(tokens_r_q[0]) - n);
            int c_q = Convert.ToInt32(tokens_r_q[1]) - 1;

            Cell[,] obstacles = new Cell[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    obstacles[i, j] = new Cell();
                }
            }

            for (int obstacles_i = 0; obstacles_i < k; obstacles_i++)
            {
                int[] obstacles_temp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                //obstacles[obstacles_i] = Array.ConvertAll(obstacles_temp, Int32.Parse);

                int x = Math.Abs(obstacles_temp[0] - n);
                int y = obstacles_temp[1] - 1;

                obstacles[x, y].IsObstackle = true;

            }

            int result = queensAttack(n, r_q, c_q, obstacles);

            Console.WriteLine(result);
        }
    }
}
