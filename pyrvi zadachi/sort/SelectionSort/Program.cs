using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> output = new List<int>();
            Sort(input);
            Console.WriteLine(string.Join(" ", input));
            Find(numbers, input, output);
            Console.WriteLine(string.Join(" ", output ));
            //int count = 1;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int num = numbers[i];
            //    Console.WriteLine(num + " num");
            //    for (int z = 0; z < input.Length; z++)
            //    {
            //        count++;
            //        Console.WriteLine(count + " count");
            //       // Console.WriteLine(z++);
            //        if (num == count)
            //        {
            //            output.Add(input[num-1]);
            //            continue;
            //        }
            //    }
            //}
        }
        static List<int> Find(int[] numbers, int[] input, List<int> output) {
            int n = numbers[0];
            int m = numbers[1];
            for (int i = 0; i < input.Length ; i++)
            {
                if (i+1 == n )
                {
                    output.Add(input[n-1]);
                }
                else
                {
                    if (i + 1 == m)
                    {
                        output.Add(input[m - 1]);
                    }
                }
            }
            return output;

        }
        static int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                int k = i;
                for (int e = i + 1; e < input.Length; e++)
                {
                    if (input[e] >= input[k])
                    {
                        k = e;
                    }

                }
                int x = input[i];
                input[i] = input[k];
                input[k] = x;
            }

            return input;
        }
    }
}
