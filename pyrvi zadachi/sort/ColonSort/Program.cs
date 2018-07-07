using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonSort
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] massive = Console.ReadLine().Split().Select(ushort.Parse).ToArray();
            List<ushort[]> insert = new List<ushort[]>();
            for (int i = 0; i < massive[0]; i++)
            {
                ushort[] inputs = Console.ReadLine().Split().Select(ushort.Parse).ToArray();
                insert.Add(inputs);
            }
            SortLists(insert, massive[2]);
            PrintPrint(insert);
        }
        static List<ushort[]> SortLists(List<ushort[]> list, ushort num)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int u = i;
                for (int z = i + 1; z < list.Count; z++)
                {
                    if (list[z][num-1] < list[u][num-1])//!!!!!!!!!!!!!!!!! '-1'
                    {
                        u = z;
                    }

                }
                ushort[] finish = list[i];
                list[i] = list[u];
                list[u] = finish;
            }
            return list;
        }
        static void PrintPrint(List<ushort[]> finish)
        {
            foreach (var item in finish)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
