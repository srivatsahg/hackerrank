using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingClouds
{
    public class JumpingClouds
    {
        static void Main(string[] args)
        {
            //int[] clouds = { 0, 0, 0, 0, 1, 0 };
            //int[] clouds = { 0, 0, 1, 0, 0, 1, 0 };
            int[] clouds = { 0, 0, 1, 0};
            Console.WriteLine("Jumping Clouds");
            Console.WriteLine($"Minimum jumps required is : { jumpingOnClouds(clouds) }");
            Console.ReadLine();
        }

        static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            int curr_pos = 0;
            int clouds = c.Length;

            for (int i = curr_pos; i < clouds; i++)
            {
                if ((curr_pos + 2 < clouds) && (c[curr_pos + 2] == 0))
                {
                    curr_pos = curr_pos + 2;
                    Console.WriteLine("Current position now is : " + curr_pos.ToString());
                    jumps++;
                }

                else if ((curr_pos + 1 < clouds) && (c[curr_pos + 1] == 0)){
                    curr_pos = curr_pos + 1;
                    Console.WriteLine("Current position now is : " + curr_pos.ToString());
                    jumps++;
                }
            }

            return jumps;
        }
    }
}
