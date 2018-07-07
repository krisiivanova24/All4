using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] arr = Console.ReadLine().Split().Select(ushort.Parse).ToArray();
            List<ushort> output = new List<ushort>();
            Sort(arr);
           Array.Reverse(arr);
            //Console.WriteLine(string.Join(" ", arr));
            FindAndCount(arr, output );
        }
        static ushort[] Sort(ushort[] arr) {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int t = 0; t < arr.Length-1; t++)
                {
                    if (arr[t]> arr[t+1])
                    {
                        ushort q = arr[t + 1];
                        arr[t + 1] = arr[t];
                        arr[t] = q;
                    }
                }
            }
            return arr;
        }
        static void FindAndCount(ushort[] arr, List<ushort> output)
        {
            ushort count = 1;
            ushort elem = arr[0];

            ushort maxC = count;
            ushort maxEl = elem;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    count++;
                    if (count > maxC )
                    {
                        maxC = count;
                        maxEl = arr[i];
                        count = 1;
                    }
                }
            }
            output.Add(maxC );
            output.Add(maxEl );
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
