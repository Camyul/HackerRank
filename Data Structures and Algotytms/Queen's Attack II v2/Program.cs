using System;
using System.Linq;

namespace Queen_s_Attack_II_v2
{
    class Program
    {
        static int queensAttack(int n, int r_q, int c_q, int[][] obstacles)
        {
            int result = 0;
            bool isObstackle = false;

            //Down
            for (int i = r_q - 1, j = c_q; i > 0; i--)
            {
                foreach (var item in obstacles)
                {
                    if (i == item[0] && j == item[1])
                    {
                        isObstackle = true;
                        break;
                    }
                }
                if (!isObstackle)
                {
                    result++;
                }
                else
                {
                    isObstackle = false;
                    break;
                }
            }

            //Up
            for (int i = r_q + 1, j = c_q; i <= n; i++)
            {
                foreach (var item in obstacles)
                {
                    if (i == item[0] && j == item[1])
                    {
                        isObstackle = true;
                        break;
                    }
                }
                if (!isObstackle)
                {
                    result++;
                }
                else
                {
                    isObstackle = false;
                    break;
                }
            }

            //Left
            for (int i = r_q, j = c_q - 1; j > 0; j--)
            {
                foreach (var item in obstacles)
                {
                    if (i == item[0] && j == item[1])
                    {
                        isObstackle = true;
                        break;
                    }
                }
                if (!isObstackle)
                {
                    result++;
                }
                else
                {
                    isObstackle = false;
                    break;
                }
            }

            //Right
            for (int i = r_q, j = c_q + 1; j <= n; j++)
            {
                foreach (var item in obstacles)
                {
                    if (i == item[0] && j == item[1])
                    {
                        isObstackle = true;
                        break;
                    }
                }
                if (!isObstackle)
                {
                    result++;
                }
                else
                {
                    isObstackle = false;
                    break;
                }
            }

            //Up & Right
            for (int i = r_q + 1, j = c_q + 1; j <= n && i <= n; j++, i++)
            {
                foreach (var item in obstacles)
                {
                    if (i == item[0] && j == item[1])
                    {
                        isObstackle = true;
                        break;
                    }
                }
                if (!isObstackle)
                {
                    result++;
                }
                else
                {
                    isObstackle = false;
                    break;
                }
            }

            //Up & Left
            for (int i = r_q + 1, j = c_q - 1; j > 0 && i <= n; j--, i++)
            {
                foreach (var item in obstacles)
                {
                    if (i == item[0] && j == item[1])
                    {
                        isObstackle = true;
                        break;
                    }
                }
                if (!isObstackle)
                {
                    result++;
                }
                else
                {
                    isObstackle = false;
                    break;
                }
            }

            //Down & Right
            for (int i = r_q - 1, j = c_q + 1; j <= n && i > 0; j++, i--)
            {
                foreach (var item in obstacles)
                {
                    if (i == item[0] && j == item[1])
                    {
                        isObstackle = true;
                        break;
                    }
                }
                if (!isObstackle)
                {
                    result++;
                }
                else
                {
                    isObstackle = false;
                    break;
                }
            }

            //Up & Left
            for (int i = r_q - 1, j = c_q - 1; j > 0 && i > 0; j--, i--)
            {
                foreach (var item in obstacles)
                {
                    if (i == item[0] && j == item[1])
                    {
                        isObstackle = true;
                        break;
                    }
                }
                if (!isObstackle)
                {
                    result++;
                }
                else
                {
                    isObstackle = false;
                    break;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] tokens_r_q = Console.ReadLine().Split(' ');
            int r_q = Convert.ToInt32(tokens_r_q[0]);
            int c_q = Convert.ToInt32(tokens_r_q[1]);

            int[][] obstacles = new int[k][];

            for (int obstacles_i = 0; obstacles_i < k; obstacles_i++)
            {
                obstacles[obstacles_i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int result = queensAttack(n, r_q, c_q, obstacles);

            Console.WriteLine(result);

        }
    }
}
