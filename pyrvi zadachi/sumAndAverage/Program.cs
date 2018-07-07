using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = massive1.Sum();
            double average = massive1.Average();
            Console.WriteLine($"Sum={sum}; Average={average:f2}");
        }
    }
}
