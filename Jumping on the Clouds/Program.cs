using System;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            var jumps = 0;

            for (int i = 1; i < c.Length; i++)
            {
                if(i + 1 <= c.Length-1)
                {
                    if (c[i + 1] == 0)
                    {
                        i++;
                    }
                }

                jumps++;
            }

            return jumps;
        }

        static void Main(string[] args)
        {
            int[] c = Array.ConvertAll("0 0 0 1 0 0".Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);

            Console.WriteLine("Total Jumps: " + result);
        }
    }
}
