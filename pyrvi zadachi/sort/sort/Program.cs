using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortAndPrint(massive);

        }
        static void SortAndPrint(int[] massive)
        {
            for (int i = 0; i < massive.Length - 1; i++)
            {
                int k = i;
                for (int r = i + 1; r < massive.Length; r++)
                {
                    if (massive[k] < massive[r])
                    {
                        k = r;
                    }

                }
                int z = massive[i];
                massive[i] = massive[k];
                massive[k] = z;
            }
            Console.WriteLine(string.Join(" ", massive));
        }
    }
}
