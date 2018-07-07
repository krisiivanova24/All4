using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uravnovesenList2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            num = num / 2;
            List<int> res1 = new List<int>();
            List<int> output = new List<int>();

            Sort(arr, num);
            Sort2(arr, num);
            //res1.AddRange(arr);

            Console.WriteLine(string.Join(" ", arr));

        }
        static List<int> Sort(List<int> arr, int num)
        {
            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int g = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = g;
                    }
                }
            }
           // Console.WriteLine(string.Join( " ...>", arr));

            return arr;
        }
        static List<int> Sort2(List<int> arr, int num)
        {
            for (int i = num; i < arr.Count-1; i++)
            {
                for (int r = num; r < arr.Count -1; r++)
                {
                    if (arr[r+1] > arr[r])
                    {
                        int w = arr[r + 1];
                        arr[r + 1] = arr[r];
                        arr[r] = w;
                    }
                }
            }
            
            return arr;
        }
    }
}

