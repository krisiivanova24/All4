using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortAndAthor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (!dic.Keys.Contains(input[i]))
                {
                    dic.Add(input[i], 1);
                }
                else
                {
                    dic[input[i]]++;
                }
            }
            List<int> output = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {

                if (dic[input[i]] % 2 == 0)
                {
                    output.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(", ",output  ));
        }
    }
}
