using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posledovatelnost
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Reverse();
            List<int> output = new List<int>();
            int count = 1;
            int num = 0;
            for (int i = 0; i < input.Count-1; i++)
            {
                if (input[i] == input [i+1])
                {
                    count++;
                    num = input[i];
                    //output.Add(input[i]);
                }
            }
            for (int i = 0; i < count; i++)
            {
                output.Add(num);
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
