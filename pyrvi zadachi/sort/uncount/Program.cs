using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uncount
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            List<int> input = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary.Add(input[i], 1);
                }
                else
                {
                    dictionary[input[i]]++;
                }
            }

            List<int> result = new List<int>();
            foreach (var pair in dictionary )
            {
                if (pair.Value%2==0)
                {
                    result.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }*/
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            Dictionary<int, int> values = new Dictionary<int, int>();

            for (int i = 0; i < input.Count; ++i)
            {
                if (values.ContainsKey(input[i]))
                {
                    values[input[i]] += 1; 
                }
                else
                {
                    values.Add(input[i], 1);
                }
            }
            List<int> output = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (values[input[i]] % 2 == 0)
                {
                    output.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join(" ", output));

        }
    }
}
